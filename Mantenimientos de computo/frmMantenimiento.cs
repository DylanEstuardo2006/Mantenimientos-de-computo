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
    public partial class frmMantenimiento : Form
    {
        private clsConexion conexion;
        Validaciones Objeto = new Validaciones(); // <--- Creamos un objeto de la clase Validaciones para usar sus metodos de validaciones
        public frmMantenimiento()
        {
            InitializeComponent();
        }


        private void frmMantenimiento_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // <--- Con este metodo le quitamos al usuario la capacidad de mover conn el cursor el form 
            this.MaximizeBox = false; // <--- Quitamos la capacidad de hacerlo a tamaño completo la pantalla el form 
            cargaDatos();   // <--- Cargamos los datos 
            DgvMantenimiento.EnableHeadersVisualStyles = false; // Necesario para que se apliquen los estilos personalizados
            DgvMantenimiento.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(47, 65, 86);
            DgvMantenimiento.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }

        private void cargaDatos()
        {
            conexion = new clsConexion();
            MySqlConnection con = conexion.getConnection();

            //Comprobamos que se conecto correctamente 

            if (con != null)
            {
                //Creamos la consulta 

                string consulta = "SELECT mantenimiento.Estado,mantenimiento.Id_mantenimiento,mantenimiento.Fecha_inicio,mantenimiento.Fecha_fin,mantenimiento.Id_diagnostico From mantenimiento,diagnostico where mantenimiento.Estado = 1 AND mantenimiento.Id_diagnostico = diagnostico.Id_diagnostico";
                //Creamos un adaptador 

                MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, con);

                //Creamos una datable 

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                //Asignamos el datatable al souce del datagrid 

                DgvMantenimiento.DataSource = dataTable;

                DgvMantenimiento.Columns["Id_mantenimiento"].Visible = false;
                DgvMantenimiento.Columns["Estado"].Visible = false; // <--- Ocultamos la columna de Estado por seguridad   
                DgvMantenimiento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                MessageBox.Show("Error al conectar");
            }

        }
        private void btnVolver_Click(object sender, EventArgs e) //
        {
            this.Hide();
            MenuPrincipal principal = new MenuPrincipal();
            principal.Show();
        }
        private void txtIdDiagnostico_KeyPress(object sender, KeyPressEventArgs e)
        {
            Objeto.ValidarNumeros(e);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            DateTime FechaInicio = DtmFechaInicial.Value;
            DateTime FechaFinal = DtmFechaFinal.Value;
            string IdDiagnostico = txtIdDiagnostico.Text;
            string Estado = "1";

            if (FechaInicio > FechaFinal)
            {
                MessageBox.Show("Las Fechas muestran incoherencias");
            }
            else
            {

                if (string.IsNullOrEmpty(IdDiagnostico))
                {
                    MessageBox.Show("Te falta llenar Diagnostico");
                }


                conexion = new clsConexion();
                MySqlConnection conn = conexion.getConnection(); //<--- Obtiene el metodo Conexion 
                string consultaValidacion = "SELECT COUNT(*) FROM diagnostico WHERE Id_diagnostico = @Id_diagnostico AND Estado = 1";
                MySqlCommand validarCmd = new MySqlCommand(consultaValidacion, conn);
                validarCmd.Parameters.AddWithValue("@Id_diagnostico", IdDiagnostico);

                int existe = Convert.ToInt32(validarCmd.ExecuteScalar());

                if (existe == 0)
                {
                    MessageBox.Show("El ID de diagnóstico no existe. Verifica el valor.");
                    conn.Close();
                    return;
                }
                //Insertar los valores 
                string consulta = "INSERT INTO mantenimiento (Fecha_inicio,Fecha_fin,Id_diagnostico,Estado)" +
                      "VALUES (@Fecha_inicio,@Fecha_fin,@Id_diagnostico,@Estado)";

                MySqlCommand command = new MySqlCommand(consulta, conn); //<----Command 
                command.Parameters.AddWithValue("@Fecha_inicio", FechaInicio);
                command.Parameters.AddWithValue("@Fecha_fin", FechaFinal);
                command.Parameters.AddWithValue("@Id_diagnostico", IdDiagnostico);
                command.Parameters.AddWithValue("@Estado", Estado);
                try
                {
                    int filasAfectadas = command.ExecuteNonQuery();

                    conn.Close(); // <--- Cerramos la conexion
                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Mantenimiento registrado correctamente");
                        cargaDatos(); // <--- Recargamos los datos del datagrid
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar el mantenimiento");
                    }
                }
                catch
                {
                    MessageBox.Show("Error al registrar el mantenimiento, El Id no coincide con ninguno de los diagnosticos");
                }

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(lblIDMantenimiento.Text))
            {
                MessageBox.Show("Porfavor seleccione un diagnostico de la tabla para Eliminar sus datos");
                return; // <--- Si no hay un tecnico seleccionado, se sale del metodo
            }
            string Estado = "0"; //<----- Constante que permite cambiar el estado del usuario y hacerlo accesible o no 
            int IdMantenimiento = Convert.ToInt32(lblIDMantenimiento.Text);
            int IdEjemplar = Convert.ToInt32(txtIdDiagnostico.Text); // <--- Obtenemos el Id del ejemplar para mostrarlo en el mensaje de confirmación
            DialogResult result = MessageBox.Show("En verdad quieres eliminar el mantenimiento en el Id: " + IdMantenimiento, "Eliminar", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                return;
            }
            conexion = new clsConexion();
            MySqlConnection con = conexion.getConnection();



            string consulta;
            MySqlCommand command;
            consulta = "update mantenimiento set Estado=@Estado where Id_mantenimiento=@Id_mantenimiento"; //<----- En este apartado hacemos una eliminación logica y no Física, evitamos un mensaje de error 
            command = new MySqlCommand(consulta, con);

            command.Parameters.AddWithValue("@Estado", Estado);
            command.Parameters.AddWithValue("@Id_diagnostico", IdMantenimiento);

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
            txtIdDiagnostico.Text = "";
        }

        private void DgvMantenimiento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = DgvMantenimiento.Rows[e.RowIndex];
                DateTime FechaInicial = Convert.ToDateTime(fila.Cells["Fecha_inicio"].Value);
                DtmFechaInicial.Value = FechaInicial;
                DateTime FechaFinal = Convert.ToDateTime(fila.Cells["Fecha_fin"].Value);
                DtmFechaFinal.Value = FechaFinal;
                txtIdDiagnostico.Text = fila.Cells["Id_diagnostico"].Value.ToString();
                lblIDMantenimiento.Text = fila.Cells["Id_mantenimiento"].Value.ToString();

            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblIDMantenimiento.Text))
            {
                MessageBox.Show("Porfavor seleccione un tecnico de la tabla para actualizar sus datos");
                return; // <--- Si no hay un tecnico seleccionado, se sale del metodo
            }
            //En este apartado obtenemos los datos de las cajas de texto 
            int IdMantenimiento = Convert.ToInt32(lblIDMantenimiento.Text);
            DateTime FechaInicial = DtmFechaInicial.Value;
            DateTime FechaFinal = DtmFechaFinal.Value;
            string IdDiagnostico = txtIdDiagnostico.Text;

            if (FechaInicial > FechaFinal)
            {
                MessageBox.Show("Las Fechas muestran incoherencias");
            }
            else
            {

                if (string.IsNullOrEmpty(IdDiagnostico))
                {
                    MessageBox.Show("Te falta llenar Diagnostico");
                }

                conexion = new clsConexion();
                MySqlConnection con = conexion.getConnection();

                string consulta;
                MySqlCommand command;

                string consultaValidacion = "SELECT COUNT(*) FROM diagnostico WHERE Id_diagnostico = @Id_diagnostico AND Estado = 1";
                MySqlCommand validarCmd = new MySqlCommand(consultaValidacion, con);
                validarCmd.Parameters.AddWithValue("@Id_diagnostico", IdDiagnostico);

                int existe = Convert.ToInt32(validarCmd.ExecuteScalar());

                if (existe == 0)
                {
                    MessageBox.Show("El ID de diagnóstico no existe. Verifica el valor.");
                
                    return;
                }

                consulta = "Update mantenimiento set Fecha_inicio=@Fecha_inicio,Fecha_fin=@Fecha_fin,Id_diagnostico=@Id_diagnostico where Id_mantenimiento=@Id_mantenimiento";
                command = new MySqlCommand(consulta, con);

                command.Parameters.AddWithValue("@Fecha_inicio", FechaInicial);
                command.Parameters.AddWithValue("@Fecha_fin", FechaFinal);
                command.Parameters.AddWithValue("@Id_diagnostico", IdDiagnostico);
                command.Parameters.AddWithValue("@Id_mantenimiento", IdMantenimiento);


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
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBusqueda.Text;
            conexion = new clsConexion();

            MySqlConnection con = conexion.getConnection();

            // Consulta y busca los tecnicos mediante su nombre, apellidos o Telefono (Falta activarlo mediante Email)
            string consulta = "SELECT mantenimiento.Id_mantenimiento,mantenimiento.Fecha_inicio,mantenimiento.Fecha_fin,mantenimiento.Id_diagnostico FROM mantenimiento WHERE (mantenimiento.Fecha_inicio LIKE @busqueda OR mantenimiento.Fecha_fin LIKE @busqueda OR mantenimiento.Id_diagnostico LIKE @busqueda) AND mantenimiento.Estado = 1";


            MySqlCommand command = new MySqlCommand(consulta, con);
            command.Parameters.AddWithValue("@busqueda", "%" + filtro + "%");

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);
            DgvMantenimiento.DataSource = table;
            DgvMantenimiento.Columns["Id_mantenimiento"].Visible = false;
            con.Close();
        }

    
    }
}

