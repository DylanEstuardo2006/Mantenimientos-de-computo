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
    public partial class frmLaboratorios : Form
    {
        Validaciones Objeto = new Validaciones();
        private clsConexion conexion; // <----- Creamos la conexión privada 
        public frmLaboratorios()
        {
            InitializeComponent();
        }

        private void frmLaboratorios_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // <--- Con este metodo le quitamos al usuario la capacidad de mover conn el cursor el form 
            this.MaximizeBox = false; // <--- Quitamos la capacidad de hacerlo a tamaño completo la pantalla el form 
            cargaDatos();   // <--- Cargamos los datos 
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal principal = new MenuPrincipal();
            principal.Show();
        }
        private void cargaDatos()
        {
            conexion = new clsConexion();
            MySqlConnection con = conexion.getConnection();

            //Comprobamos que se conecto correctamente 
            if (con != null)
            {
                //Creamos la consulta 
                string consulta = "SELECT laboratorios.Id_laboratorios, laboratorios.Nombre_laboratorio, laboratorios.Estado FROM laboratorios WHERE Estado = 1";

                //Creamos un adaptador 
                MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, con);

                //Creamos una datable 
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                //Asignamos el datatable al souce del datagrid 
                DgvLaboratorios.DataSource = dataTable;

                DgvLaboratorios.Columns["Id_laboratorios"].Visible = false;
                DgvLaboratorios.Columns["Estado"].Visible = false; // <--- Ocultamos la columna de Estado por seguridad   
                DgvLaboratorios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                MessageBox.Show("Error al conectar");
            }
        }

        private void txtNombreLaboratorio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Objeto.ValidarSeparadores(e);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //En este apartado obtenemos los datos de las cajas de texto 
            string Nombre = txtNombreLaboratorio.Text;
            string Estado = "1"; // <----- Constante que permite Poner el estado del laboratorio como activo

            //En este if validamos con el IsNullOrEmpty para evitar que si el usuario no ingresa algun campo le salga un mensaje de faltan casillas por llenar 
            if (string.IsNullOrEmpty(Nombre))
            {
                MessageBox.Show("Faltan casillas por llenar");
            }
            else
            {
                conexion = new clsConexion();
                MySqlConnection conn = conexion.getConnection(); //<--- Obtiene el metodo Conexion 

                //Insertar los valores 
                string consulta = "INSERT INTO laboratorios (Nombre_laboratorio, Estado) VALUES (@Nombre_laboratorio, @Estado)";

                MySqlCommand command = new MySqlCommand(consulta, conn); //<----Command 
                command.Parameters.AddWithValue("@Nombre_laboratorio", Nombre);
                command.Parameters.AddWithValue("@Estado", Estado); // <--- Estado por defecto al registrar un laboratorio

                int filasAfectadas = command.ExecuteNonQuery();
                conn.Close();

                if (filasAfectadas > 0) //<---- Verificación que se haya echo correctamente
                {
                    MessageBox.Show("Registro exitoso...");
                    cargaDatos();
                }
                else
                {
                    MessageBox.Show("Algo anda mal...");
                }
            }
            // En este apartado la caja se limpia inmediatamente de haber echo la operación 
            txtNombreLaboratorio.Text = "";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblIDLaboratorio.Text))
            {
                MessageBox.Show("Ingrese un valor de la tabla antes de actualizar");
            }
            //En este apartado obtenemos los datos de las cajas de texto 
            string Nombre = txtNombreLaboratorio.Text;
            string IdLaboratorio = lblIDLaboratorio.Text;
            conexion = new clsConexion();
            MySqlConnection con = conexion.getConnection();

            if (string.IsNullOrEmpty(Nombre))
            {
                MessageBox.Show("Faltan casillas por llenar");
            }
            else
            {
                string consulta = "UPDATE laboratorios SET Nombre_laboratorio=@Nombre_laboratorio WHERE Id_laboratorios=@Id_laboratorios";
                MySqlCommand command = new MySqlCommand(consulta, con);

                command.Parameters.AddWithValue("@Nombre_laboratorio", Nombre);
                command.Parameters.AddWithValue("@Id_laboratorios", IdLaboratorio);
                int filasAfectadas = command.ExecuteNonQuery();
                con.Close();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Registro editado exitosamente...");
                    cargaDatos();
                }
                else
                {
                    MessageBox.Show("Error al actualizar...");
                }
            }
            // En este apartado la caja se limpia inmediatamente de haber echo la operación 
            txtNombreLaboratorio.Text = "";
        }

        private void DgvLaboratorios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = DgvLaboratorios.Rows[e.RowIndex];
                txtNombreLaboratorio.Text = fila.Cells["Nombre_laboratorio"].Value?.ToString();
                lblIDLaboratorio.Text = fila.Cells["Id_laboratorios"].Value?.ToString();
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBusqueda.Text;
            conexion = new clsConexion();

            MySqlConnection con = conexion.getConnection();

            // Consulta y busca los laboratorios mediante su nombre
            string consulta = "SELECT laboratorios.Id_laboratorios, laboratorios.Nombre_laboratorio, laboratorios.Estado FROM laboratorios WHERE laboratorios.Nombre_laboratorio LIKE @busqueda AND laboratorios.Estado = 1";

            MySqlCommand command = new MySqlCommand(consulta, con);
            command.Parameters.AddWithValue("@busqueda", "%" + filtro + "%");

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);
            DgvLaboratorios.DataSource = table;
            DgvLaboratorios.Columns["Id_laboratorios"].Visible = false;
            DgvLaboratorios.Columns["Estado"].Visible = false;
            con.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string Estado = "0"; //<----- Constante que permite cambiar el estado del laboratorio y hacerlo accesible o no 
            string IdLaboratorio = lblIDLaboratorio.Text;

            conexion = new clsConexion();
            MySqlConnection con = conexion.getConnection();

            string consulta = "UPDATE laboratorios SET Estado=@Estado WHERE Id_laboratorios=@Id_laboratorios"; //<----- En este apartado hacemos una eliminación logica y no Física, evitamos un mensaje de error 
            MySqlCommand command = new MySqlCommand(consulta, con);

            command.Parameters.AddWithValue("@Estado", Estado);
            command.Parameters.AddWithValue("@Id_laboratorios", IdLaboratorio);

            int filasAfectadas = command.ExecuteNonQuery();
            con.Close();

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Se eliminó exitosamente");
                cargaDatos();
            }
            else
            {
                MessageBox.Show("Algo anda mal....");
            }
            // En este apartado la caja se limpia inmediatamente de haber echo la operación 
            txtNombreLaboratorio.Text = "";
        }
    }
}
