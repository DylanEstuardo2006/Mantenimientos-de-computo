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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Mantenimientos_de_computo
{
    public partial class frmTipoDispositivo : Form
    {
        private clsConexion conexion;
        Validaciones objeto = new Validaciones();
        public frmTipoDispositivo()
        {
            InitializeComponent();
        }

        private void frmTipoDispositivo_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            cargarDatos();
        }
        private void cargarDatos()
        {
            conexion = new clsConexion();
            MySqlConnection con = conexion.getConnection();

            // Comprobamos que se conecto correctamente 

            if (con != null)
            {
                //Creamos la consulta 

                string consulta = "SELECT tipodispositivo.Id_tipodispositivo,tipodispositivo.Tipodispositivo FROM tipodispositivo where Estado = 1";

                //Creamos un adaptador 

                MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, con);

                //Creamos una datable 

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                //Asignamos el datatable al souce del datagrid 

                DgvTipoDispositivo.DataSource = dataTable;

                DgvTipoDispositivo.Columns["Id_tipodispositivo"].Visible = false;
                DgvTipoDispositivo.Columns["Estado"].Visible = false; // <--- Ocultamos la columna de Estado por seguridad   
                DgvTipoDispositivo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                MessageBox.Show("Error al conectar");
            }

        }

        private void txtTipoDispositivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            objeto.ValidarLetras(e);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string TipoDispositivo = txtTipoDispositivo.Text;
            string Estado = "1"; // <----- Constante que permite Poner el estado de el usuario como activo o negativo 

            //En este if validamos con el IsNullOrEmpty para evitar que si el usuario no ingresa algun campo le salga un mensaje de faltan casillas por llenar 
            if (string.IsNullOrEmpty(TipoDispositivo))
            {
                MessageBox.Show("Faltan casillas por llenar");

            }
            else
            {

                conexion = new clsConexion();
                MySqlConnection conn = conexion.getConnection(); //<--- Obtiene el metodo Conexion 

                //Insertar los valores 
                string consulta = "INSERT INTO tipodispositivo (Tipodispositivo,Estado)" +
                  "VALUES (@Tipodispositivo,@Estado)";

                MySqlCommand command = new MySqlCommand(consulta, conn); //<----Command 
                command.Parameters.AddWithValue("@Tipodispositivo", TipoDispositivo);
                command.Parameters.AddWithValue("@Estado", Estado); // <--- Estado por defecto al registrar un técnico
                int filasAfectadas = command.ExecuteNonQuery();
                conn.Close();

                if (filasAfectadas > 0) //<---- Verificación que se haya echo correctamente
                {
                    MessageBox.Show("Registro extitoso...");
                    cargarDatos();
                }
                else
                {
                    MessageBox.Show("Algo anda mal...");
                }
            }
            txtTipoDispositivo.Text = ""; // <--- Limpia la caja de texto después de registrar un nuevo tipo de dispositivo    
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblIDTipoDispositivo.Text))
            {
                MessageBox.Show("Porfavor seleccione un tecnico de la tabla para actualizar sus datos");
                return; // <--- Si no hay un tecnico seleccionado, se sale del metodo
            }
            //En este apartado obtenemos los datos de las cajas de texto 
            int IdTecnico = Convert.ToInt32(lblIDTipoDispositivo.Text);
            string TipoDispositivo = lblIDTipoDispositivo.Text;

            conexion = new clsConexion();
            MySqlConnection con = conexion.getConnection(); //<--- Obtiene el metodo Conexion

            string consulta;
            MySqlCommand command;

            if (string.IsNullOrEmpty(TipoDispositivo)) //<--- Validamos que no se deje la caja de texto vacia
            {
                MessageBox.Show("Faltan casillas por llenar");
            }
            else
            {
                //Actualizamos los datos del tecnico 
                consulta = "UPDATE tipodispositivo SET Tipodispositivo = @Tipodispositivo WHERE Id_tipodispositivo = @Id_tipodispositivo";
                command = new MySqlCommand(consulta, con);
                command.Parameters.AddWithValue("@Tipodispositivo", TipoDispositivo);
                command.Parameters.AddWithValue("@Id_tipodispositivo", IdTecnico);
                int filasAfectadas = command.ExecuteNonQuery();
                con.Close();
                if (filasAfectadas > 0) //<--- Verificación que se haya echo correctamente
                {
                    MessageBox.Show("Actualización exitosa...");
                    cargarDatos();
                }
                else
                {
                    MessageBox.Show("Algo anda mal...");
                }
            }
        }
        private void DgvTipoDispositivo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // <--- Verificamos que la fila seleccionada sea valida
            {
                DataGridViewRow row = DgvTipoDispositivo.Rows[e.RowIndex]; // <--- Obtenemos la fila seleccionada
                lblIDTipoDispositivo.Text = row.Cells["Id_tipodispositivo"].Value.ToString(); // <--- Obtenemos el ID del tecnico seleccionado
                txtTipoDispositivo.Text = row.Cells["Tipodispositivo"].Value.ToString(); // <--- Obtenemos el nombre del tecnico seleccionado
            }
        }
        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBusqueda.Text; // <--- Obtenemos el texto de la caja de busqueda
            conexion = new clsConexion();
            MySqlConnection con = conexion.getConnection(); // <--- Obtiene el metodo Conexion
            if (con != null)
            {
                string consulta = "SELECT tipodispositivo.Id_tipodispositivo,tipodispositivo.Tipodispositivo FROM tipodispositivo WHERE Estado = 1 AND Tipodispositivo LIKE @Busqueda"; // <--- Consulta para buscar por nombre
                MySqlCommand command = new MySqlCommand(consulta, con);
                command.Parameters.AddWithValue("@Busqueda", "%" + txtBusqueda.Text + "%"); // <--- Agrega el parametro de busqueda
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                DgvTipoDispositivo.DataSource = dataTable;
                DgvTipoDispositivo.Columns["Id_tipodispositivo"].Visible = false; // <--- Ocultamos la columna de ID por seguridad
                DgvTipoDispositivo.Columns["Estado"].Visible = false; // <--- Ocultamos la columna de Estado por seguridad
                DgvTipoDispositivo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                MessageBox.Show("Error al conectar");
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string Estado = "0"; // <--- Constante que permite Poner el estado de el tecnico como eliminado
            if (string.IsNullOrWhiteSpace(lblIDTipoDispositivo.Text)) // <--- Verificamos que se haya seleccionado un tecnico
            {
                MessageBox.Show("Porfavor seleccione un tecnico de la tabla para eliminarlo");
                return; // <--- Si no hay un tecnico seleccionado, se sale del metodo
            }
            int IdTecnico = Convert.ToInt32(lblIDTipoDispositivo.Text); // <--- Obtenemos el ID del tecnico seleccionado
            conexion = new clsConexion();
            MySqlConnection con = conexion.getConnection(); // <--- Obtiene el metodo Conexion
            string consulta = "UPDATE tipodispositivo SET Estado=@Estado WHERE Id_tipodispositivo = @Id_tipodispositivo"; // <--- Consulta para eliminar el tecnico
            MySqlCommand command = new MySqlCommand(consulta, con);
            command.Parameters.AddWithValue("@Estado", Estado); // <--- Cambiamos el estado del tecnico a 0 para eliminarlo
            command.Parameters.AddWithValue("@Id_tipodispositivo", IdTecnico);
            int filasAfectadas = command.ExecuteNonQuery();
            con.Close();
            if (filasAfectadas > 0) // <--- Verificación que se haya echo correctamente
            {
                MessageBox.Show("Eliminación exitosa...");
                cargarDatos();
                lblIDTipoDispositivo.Text = ""; // <--- Limpia la etiqueta del ID del tecnico seleccionado
                txtTipoDispositivo.Text = ""; // <--- Limpia la caja de texto del nombre del tecnico seleccionado
            }
            else
            {
                MessageBox.Show("Algo anda mal...");
            }
        }

    }
}

