using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mantenimientos_de_computo
{
    public partial class frmEjemplares : Form
    {
        private clsConexion conexion;
        Validaciones Objeto = new Validaciones(); // <--- Creamos un objeto de la clase Validaciones para usar sus metodos de validaciones
        public frmEjemplares()
        {
            InitializeComponent();
        }

        private void frmEjemplares_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // <--- Con este metodo le quitamos al usuario la capacidad de mover conn el cursor el form 
            this.MaximizeBox = false; // <--- Quitamos la capacidad de hacerlo a tamaño completo la pantalla el form 

            cargaDatos();   // <--- Cargamos los datos 
            DgvEjemplares.EnableHeadersVisualStyles = false; // Necesario para que se apliquen los estilos personalizados
            DgvEjemplares.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(47, 65, 86);
            DgvEjemplares.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close(); // <--- Cerramos el form actual
            MenuPrincipal principal = new MenuPrincipal(); // <--- Creamos una instancia del form MenuPrincipal
            principal.Show(); // <--- Mostramos el form MenuPrincipal
        }

        private void txtIdDiagnostico_KeyPress(object sender, KeyPressEventArgs e)
        {
            Objeto.ValidarNumeros(e);
        }

        private void txtNumeroInventario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Objeto.ValidarNumeros(e);
        }

        private void txtNombreInventario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Objeto.ValidarSeparadores(e);
        }
        private void cargaDatos()
        {
            conexion = new clsConexion(); // <--- Creamos una instancia de la clase clsConexion
            MySqlConnection con = conexion.getConnection(); // <--- Obtenemos la conexión a la base de datos

            if (con != null)
            {
                string consulta = "SELECT ejemplar.Id_ejemplar,ejemplar.Estado,ejemplar.Nombre_dispositivo,ejemplar.Numero_inventario,laboratorios.Nombre_laboratorio as Laboratorio,ejemplar.Id_dispositivo FROM laboratorios,ejemplar,dispositivo WHERE ejemplar.Estado = 1 AND ejemplar.Id_laboratorio = laboratorios.Id_laboratorios AND ejemplar.Id_dispositivo = dispositivo.Id_dispositivo";

                //Creamos un adaptador 

                MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, con);

                //Creamos una datable 

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                //Asignamos el datatable al souce del datagrid 

                DgvEjemplares.DataSource = dataTable;
                // <--- Cambiamos el nombre de la columna Tipodispositivo a Tipo de Dispositivo
                DgvEjemplares.Columns["Id_ejemplar"].Visible = true;
                DgvEjemplares.Columns["Estado"].Visible = false; // <--- Ocultamos la columna de Estado por seguridad   
                DgvEjemplares.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                string consulta2 = "SELECT * FROM laboratorios where Estado = 1";
                MySqlDataAdapter adapter2 = new MySqlDataAdapter(consulta2, con);
                con.Close();

                DataTable dataTable2 = new DataTable();
                adapter2.Fill(dataTable2);
            

                cmbLaboratorio.DataSource = dataTable2;
                cmbLaboratorio.DisplayMember = "Nombre_laboratorio";
                cmbLaboratorio.ValueMember = "Id_laboratorios";
                cmbLaboratorio.SelectedIndex = -1;
                cmbLaboratorio.DropDownStyle = ComboBoxStyle.DropDownList;

                string consulta3 = "SELECT * FROM dispositivo where Estado = 1";
                MySqlDataAdapter adapter3 = new MySqlDataAdapter(consulta3, con);

                con.Close();    
                
                DataTable dataTable3 = new DataTable();
                adapter3.Fill(dataTable3);

                cmbDispositivo.DataSource = dataTable3;
                cmbDispositivo.DisplayMember = "Id_dispositivo";
                cmbDispositivo.ValueMember = "Id_dispositivo";
                cmbDispositivo .SelectedIndex = -1; 
                cmbDispositivo.DropDownStyle = ComboBoxStyle.DropDownList;
            
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            int IdDispositivo = Convert.ToInt32(cmbDispositivo.SelectedValue);
            int IdLaboratorio = Convert.ToInt32(cmbLaboratorio.SelectedValue); // <--- Obtenemos el Id del tipo de mantenimiento seleccionado   
            string NombreInventario = txtNombreInventario.Text;
            string NumeroInventario = txtNumeroInventario.Text;
            string Estado = "1"; // <--- Estado 1 para indicar que el dispositivo está activo

            if ( string.IsNullOrEmpty(NombreInventario) || string.IsNullOrEmpty(NumeroInventario) || cmbLaboratorio.SelectedIndex == -1 || cmbDispositivo.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos antes de registrar un nuevo dispositivo.");
                
            }
            else
            {

                conexion = new clsConexion();
                MySqlConnection conn = conexion.getConnection(); //<--- Obtiene el metodo Conexion 


              

                string consulta = "INSERT INTO ejemplar (Nombre_dispositivo,Numero_inventario, Id_laboratorio,Id_dispositivo,Estado) VALUES (@Nombre_dispositivo,@Numero_inventario,@Id_laboratorio,@Id_dispositivo,@Estado)";
                MySqlCommand command = new MySqlCommand(consulta, conn); //<----Command 
                command.Parameters.AddWithValue("@Nombre_dispositivo", NombreInventario);
                command.Parameters.AddWithValue("@Numero_inventario", NumeroInventario);
                command.Parameters.AddWithValue("@Id_laboratorio", IdLaboratorio);
                command.Parameters.AddWithValue("Id_dispositivo", IdDispositivo);
                command.Parameters.AddWithValue("@Estado", Estado); // <--- Estado 1 para indicar que el dispositivo está activo

                int filasAfectadas = command.ExecuteNonQuery();
                conn.Close();

                if (filasAfectadas > 0) //<---- Verificación que se haya echo correctamente
                {
                    MessageBox.Show("Registro extitoso...");
                    cargaDatos();
                }
                else
                {
                    MessageBox.Show("Algo anda mal...");
                }
            }
            cmbDispositivo.SelectedIndex = -1;
            cmbLaboratorio.SelectedIndex = -1;
            txtNombreInventario.Text= "";
            txtNumeroInventario.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblIdEjemplar.Text))
            {
                MessageBox.Show("No se ha escogido ningun valor a eliminar");
                return;
            }
            string Estado = "0";
            int IdEjemplar = Convert.ToInt32(lblIdEjemplar.Text);

            DialogResult result = MessageBox.Show("En verdad quieres eliminar el registro con el Id:" + IdEjemplar + "?"
                  , "Eliminar", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                return;
            }
            conexion = new clsConexion();
            MySqlConnection con = conexion.getConnection();

            string consulta;
            MySqlCommand command;
            consulta = "UPDATE ejemplar SET Estado=@Estado WHERE Id_ejemplar=@Id_ejemplar"; //<----- En este apartado hacemos una eliminación logica y no Física, evitamos un mensaje de error 
            command = new MySqlCommand(consulta, con);


            command.Parameters.AddWithValue("@Estado", Estado);
            command.Parameters.AddWithValue("@Id_ejemplar", IdEjemplar);

            int filasAfectadas = command.ExecuteNonQuery();
            con.Close();

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Se elimino exitosamente");
                cargaDatos();
            }
            else
            {
                MessageBox.Show("Algo Anda mal....");
            }
            // En este apartado las cajas se limpian inmediatamente de haber echo la operación 
            cmbDispositivo.SelectedIndex = -1;
            cmbLaboratorio.SelectedIndex = -1;
            txtNombreInventario.Text = "";
            txtNumeroInventario.Text = "";
        }
        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBusqueda.Text;
            conexion = new clsConexion();

            MySqlConnection con = conexion.getConnection();

            string consulta = "SELECT ejemplar.Id_ejemplar,ejemplar.Estado,ejemplar.Nombre_dispositivo,ejemplar.Numero_inventario,laboratorios.Nombre_laboratorio as Laboratorio,ejemplar.Id_dispositivo FROM ejemplar INNER JOIN laboratorios ON ejemplar.Id_laboratorio = laboratorios.Id_laboratorios WHERE ejemplar.Estado = 1 AND (ejemplar.Numero_inventario LIKE @busqueda OR ejemplar.Nombre_dispositivo LIKE @busqueda OR laboratorios.Nombre_laboratorio LIKE @busqueda OR ejemplar.Id_dispositivo LIKE @busqueda OR ejemplar.Id_ejemplar LIKE @busqueda)";

            MySqlCommand command = new MySqlCommand(consulta, con);
            command.Parameters.AddWithValue("@busqueda", "%" + filtro + "%");

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);
            DgvEjemplares.DataSource = table;
            DgvEjemplares.Columns["Id_ejemplar"].Visible = true;
            con.Close();
        }
        private void DgvEjemplares_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = DgvEjemplares.Rows[e.RowIndex];
                txtNumeroInventario.Text = fila.Cells["Numero_inventario"].Value?.ToString();
                txtNombreInventario.Text = fila.Cells["Nombre_dispositivo"].Value?.ToString();
                cmbLaboratorio.Text = fila.Cells["Laboratorio"].Value?.ToString();
                cmbDispositivo.Text = fila.Cells["Id_dispositivo"].Value?.ToString();

                lblIdEjemplar.Text = fila.Cells["Id_ejemplar"].Value.ToString();

            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int IdEjemplar = Convert.ToInt32(lblIdEjemplar.Text);
            int IdDispositivo = Convert.ToInt32(cmbDispositivo.SelectedValue);
            int IdLaboratorio = Convert.ToInt32(cmbLaboratorio.SelectedValue); // <--- Obtenemos el Id del tipo de mantenimiento seleccionado   
            string NombreInventario = txtNombreInventario.Text;
            string NumeroInventario = txtNumeroInventario.Text;
  

            if (string.IsNullOrEmpty(NombreInventario) || string.IsNullOrEmpty(NumeroInventario) || cmbLaboratorio.SelectedIndex == -1 || cmbDispositivo.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos antes de registrar un nuevo dispositivo.");

            }
            else
            {

                conexion = new clsConexion();
                MySqlConnection conn = conexion.getConnection(); //<--- Obtiene el metodo Conexion 


                string consultaNumeroInventario = "SELECT COUNT(*) FROM ejemplar WHERE  (Nombre_dispositivo = @Nombre_dispositivo OR Numero_inventario = @Numero_inventario) AND Estado = 1";
                MySqlCommand verificar = new MySqlCommand(consultaNumeroInventario, conn);

                verificar.Parameters.AddWithValue("@Nombre_dispositivo", NombreInventario);
                verificar.Parameters.AddWithValue("@Numero_inventario", NumeroInventario);

                int verifica = Convert.ToInt32(verificar.ExecuteScalar());

                if (verifica > 0)
                {
                    MessageBox.Show("El nombre del dispositivo o el Numero de Inventario ya existen. Porfavor ingrese el Numero o Nombre de inventario correcto ");
                    conn.Close();
                    return;
                }

                string consulta = "UPDATE ejemplar SET Nombre_dipositivo=@Nombre_dispositivo,Numero_inventario=@Numero_inventario,Id_laboratorio=@Id_laboratorio,Id_dispositivo=@Id_dispositivo WHERE Id_ejemplar = @Id_ejemplar";
                MySqlCommand command = new MySqlCommand(consulta, conn); //<----Command 
                command.Parameters.AddWithValue("@Nombre_dispositivo", NombreInventario);
                command.Parameters.AddWithValue("@Numero_inventario", NumeroInventario);
                command.Parameters.AddWithValue("@Id_laboratorio", IdLaboratorio);
                command.Parameters.AddWithValue("Id_dispositivo", IdDispositivo);
                command.Parameters.AddWithValue("@Id_ejemplar", IdEjemplar);

                int filasAfectadas = command.ExecuteNonQuery();
                conn.Close();

                if (filasAfectadas > 0) //<---- Verificación que se haya echo correctamente
                {
                    MessageBox.Show("Registro extitoso...");
                    cargaDatos();
                }
                else
                {
                    MessageBox.Show("Algo anda mal...");
                }
            }
            cmbDispositivo.SelectedIndex = -1;
            cmbLaboratorio.SelectedIndex = -1;
            txtNombreInventario.Text = "";
            txtNumeroInventario.Text = "";
        }
    }
}
