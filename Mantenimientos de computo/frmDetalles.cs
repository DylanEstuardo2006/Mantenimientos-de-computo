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
    public partial class frmDetalles : Form
    {
        private clsConexion conexion;
        Validaciones Objeto = new Validaciones(); // <--- Creamos un objeto de la clase Validaciones para usar sus metodos de validaciones
        public frmDetalles()
        {
            InitializeComponent();

        }

        private void frmDetalles_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // <--- Con este metodo le quitamos al usuario la capacidad de mover conn el cursor el form 
            this.MaximizeBox = false; // <--- Quitamos la capacidad de hacerlo a tamaño completo la pantalla el form 

            cargaDatos();   // <--- Cargamos los datos 
            DgvDispositivo.EnableHeadersVisualStyles = false; // Necesario para que se apliquen los estilos personalizados
            DgvDispositivo.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(47, 65, 86);
            DgvDispositivo.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close(); // <--- Cerramos el form actual
            MenuPrincipal principal = new MenuPrincipal(); // <--- Creamos una instancia del form MenuPrincipal
            principal.Show(); // <--- Mostramos el form MenuPrincipal
        }
        private void txtIdModelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Objeto.ValidarNumeros(e);
        }
        private void cargaDatos()
        {
            conexion = new clsConexion(); // <--- Creamos una instancia de la clase clsConexion
            MySqlConnection con = conexion.getConnection(); // <--- Obtenemos la conexión a la base de datos

            if (con != null)
            {
                string consulta = "SELECT dispositivo.Id_dispositivo,dispositivo.Estado,dispositivo.Id_tipodisposito,dispositivo.Id_modelo,tipodispositivo.Tipodispositivo as Tipo_Dispositivo,modelos.modelo as Modelo_Dispositivo FROM dispositivo INNER JOIN tipodispositivo ON dispositivo.Id_tipodispositivo = tipodispositivo.Id_tipodispositivo INNER JOIN modelos ON dispositivo.Id_modelo = modelos.Id_modelo"; 
                //Creamos un adaptador 

                MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, con);

                //Creamos una datable 

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                //Asignamos el datatable al souce del datagrid 

                DgvDispositivo.DataSource = dataTable;
               // <--- Cambiamos el nombre de la columna Tipodispositivo a Tipo de Dispositivo
                DgvDispositivo.Columns["Id_dispositivo"].Visible = true;
                DgvDispositivo.Columns["Id_tipodispositivo"].Visible = false;
                DgvDispositivo.Columns["Id_modelo"].Visible = false;
                DgvDispositivo.Columns["Estado"].Visible = false; // <--- Ocultamos la columna de Estado por seguridad   
                DgvDispositivo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                string consulta2 = "SELECT * FROM tipodispositivo where Estado = 1";
                MySqlDataAdapter adapter2 = new MySqlDataAdapter(consulta2, con);
                con.Close();

                DataTable dataTable2 = new DataTable();
                adapter2.Fill(dataTable2);

                cmbTipoDispositivo.DataSource = dataTable2;
                cmbTipoDispositivo.DisplayMember = "Tipodispositivo";
                cmbTipoDispositivo.ValueMember = "Id_tipodispositivo";
                cmbTipoDispositivo.SelectedIndex = -1;
                cmbTipoDispositivo.DropDownStyle = ComboBoxStyle.DropDownList;
            }

        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string IdModelo = txtIdModelo.Text; // <--- Obtenemos el modelo del dispositivo    
            int IdTipoDispositivo = Convert.ToInt32(cmbTipoDispositivo.SelectedValue); // <--- Obtenemos el Id del tipo de mantenimiento seleccionado   
            string Estado = "1"; // <--- Estado 1 para indicar que el dispositivo está activo

            if (string.IsNullOrEmpty(IdModelo) || cmbTipoDispositivo.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos antes de registrar un nuevo dispositivo.");
            }

            conexion = new clsConexion();
            MySqlConnection conn = conexion.getConnection(); //<--- Obtiene el metodo Conexion 
            string consultaValidacion = "SELECT COUNT(*) FROM modelos WHERE Id_modelo = @Id_modelo AND Estado = 1";
            MySqlCommand validarCmd = new MySqlCommand(consultaValidacion, conn);
            validarCmd.Parameters.AddWithValue("@Id_modelo", IdModelo);

            int existe = Convert.ToInt32(validarCmd.ExecuteScalar());

            if (existe == 0)
            {
                MessageBox.Show("El ID del modelo no existe. No existe en la base de datos");
                conn.Close();
                return;
            }
            string consulta = "INSERT INTO dispositivo (Id_modelo, Id_tipodispositivo, Estado) VALUES (@Id_modelo, @Id_tipodispositivo,@Estado)";
            MySqlCommand command = new MySqlCommand(consulta, conn); //<----Command 
            command.Parameters.AddWithValue("@Id_modelo", IdModelo);
            command.Parameters.AddWithValue("@Id_tipodispositivo", IdTipoDispositivo);
            command.Parameters.AddWithValue("@Estado", Estado); // <--- Estado 1 para indicar que el dispositivo está activo
            try
            {
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
            catch
            {
                MessageBox.Show("Error al registrar el diagnóstico. El Id del ejemplar no coincide con ninguno en la base de datos.");
            }
        }
        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblIdDispositivo.Text))
            {
                MessageBox.Show("Porfavor seleccione un dispositivo de la tabla para Eliminar sus datos");
                return; // <--- Si no hay un tecnico seleccionado, se sale del metodo
            }
            string Estado = "0"; //<----- Constante que permite cambiar el estado del usuario y hacerlo accesible o no 
            string NombreModelo = txtIdModelo.Text; // <--- Obtenemos el nombre del tecnico seleccionado para mostrarlo en el mensaje de confirmación
            int IdDispositivo = Convert.ToInt32(lblIdDispositivo.Text);

            DialogResult result = MessageBox.Show("En verdad quieres eliminar el registro con el modelo: " + NombreModelo + "con el id" + IdDispositivo + "?"
               , "Eliminar", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                return;
            }
            conexion = new clsConexion();
            MySqlConnection con = conexion.getConnection();

            string consulta;
            MySqlCommand command;
            consulta = "update dispositivo set Estado=@Estado where Id_dispositivo=@Id_dispositivo"; //<----- En este apartado hacemos una eliminación logica y no Física, evitamos un mensaje de error 
            command = new MySqlCommand(consulta, con);

            command.Parameters.AddWithValue("@Estado", Estado);
            command.Parameters.AddWithValue("@Id_dispositivo", IdDispositivo);

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
            cmbTipoDispositivo.SelectedIndex = -1; // <--- Limpiamos el combobox de Tecnicos  
            txtIdModelo.Text = ""; // <--- Limpiamos el textbox de Id Ejemplar
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
           
                if (string.IsNullOrWhiteSpace(lblIdDispositivo.Text))
                {
                    MessageBox.Show("Porfavor seleccione un tecnico de la tabla para actualizar sus datos");
                    return; // <--- Si no hay un tecnico seleccionado, se sale del metodo
                }
                //En este apartado obtenemos los datos de las cajas de texto 
                int IdDispositivo = Convert.ToInt32(lblIdDispositivo.Text);
                string IdModelo = txtIdModelo.Text;
                int IdTipoDispositivo = Convert.ToInt32(cmbTipoDispositivo.SelectedValue); // <--- Obtenemos el Id del tecnico seleccionado
                

                conexion = new clsConexion();
                MySqlConnection con = conexion.getConnection();

               
            string consultaValidacion = "SELECT COUNT(*) FROM modelos WHERE Id_modelo = @Id_modelo AND Estado = 1";
            MySqlCommand validarCmd = new MySqlCommand(consultaValidacion, con);
            validarCmd.Parameters.AddWithValue("@Id_modelo", IdModelo);

            int existe = Convert.ToInt32(validarCmd.ExecuteScalar());

            if (existe == 0)
            {
                MessageBox.Show("El ID del modelo no existe. No existe en la base de datos");
                con.Close();
                return;
            }

            string consulta;
            MySqlCommand command;

            consulta = "Update dispositivo set Id_modelo=@Id_modelo,Id_tipodispositivo= @Id_tipodispositivo where Id_dispositivo=@Id_dispositivo";
            command = new MySqlCommand(consulta, con);
 
            command.Parameters.AddWithValue("@Id_tipodispositivo", IdTipoDispositivo);
            command.Parameters.AddWithValue("@Id_modelo", IdModelo);
            command.Parameters.AddWithValue("@Id_dispositivo", IdDispositivo);


                    int filasAfectadas = command.ExecuteNonQuery();
                    con.Close();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Registro editado existosamente...");
                        cargaDatos();


                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar...");
                    }
                
            // En este apartado las cajas se limpian inmediatamente de haber echo la operación 
            cmbTipoDispositivo.SelectedIndex = -1; // <--- Limpiamos el combobox de Tipos de Mantenimiento
            txtIdModelo.Text = ""; // <--- Limpiamos el textbox de Id Ejemplar
        }

        private void DgvDispositivo_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = DgvDispositivo.Rows[e.RowIndex];
                txtIdModelo.Text = fila.Cells["Id_modelo"].Value?.ToString();
                cmbTipoDispositivo.Text = fila.Cells["Tipodispositivo"].Value?.ToString();
                lblIdDispositivo.Text = fila.Cells["Id_Dispositivo"].Value.ToString();

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
