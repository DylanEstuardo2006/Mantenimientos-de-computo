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
    public partial class frmHistorial : Form
    {
        private clsConexion conexion;
        public frmHistorial()
        {
            InitializeComponent();
        }
        private void frmHistorial_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // <--- Con este metodo le quitamos al usuario la capacidad de mover conn el cursor el form 
            this.MaximizeBox = false; // <--- Quitamos la capacidad de hacerlo a tamaño completo la pantalla el form 
            cargaDatos();   // <--- Cargamos los datos 
            DgvHistoria.EnableHeadersVisualStyles = false; // Necesario para que se apliquen los estilos personalizados
            DgvHistoria.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(47, 65, 86);
            DgvHistoria.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DgvHistoria.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold); // Fuente opciona

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

                string consulta = "SELECT mantenimiento.Estado,mantenimiento.Id_mantenimiento,mantenimiento.Fecha_inicio,mantenimiento.Fecha_fin,mantenimiento.Id_diagnostico FROM diagnostico,mantenimiento WHERE mantenimiento.Estado = 1 AND mantenimiento.Id_diagnostico = diagnostico.Id_diagnostico";

                MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, con);

                //Creamos una datable 

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                //Asignamos el datatable al souce del datagrid 

               DgvHistoria.DataSource = dataTable;

               DgvHistoria.Columns["Id_mantenimiento"].Visible = true;
               DgvHistoria.Columns["Estado"].Visible = false; // <--- Ocultamos la columna de Estado por seguridad   
               DgvHistoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                MessageBox.Show("Error al conectar");
            }

        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {

            string filtro = txtBusqueda.Text;
            conexion = new clsConexion();

            MySqlConnection con = conexion.getConnection();

            // Consulta y busca los tecnicos mediante su nombre, apellidos o Telefono (Falta activarlo mediante Email)
            string consulta = "SELECT mantenimiento.Id_mantenimiento,mantenimiento.Fecha_inicio,mantenimiento.Fecha_fin,mantenimiento.Id_diagnostico FROM mantenimiento WHERE (mantenimiento.Id_mantenimiento LIKE @busqueda OR mantenimiento.Id_diagnostico LIKE @busqueda) AND mantenimiento.Estado = 1";


            MySqlCommand command = new MySqlCommand(consulta, con);
            command.Parameters.AddWithValue("@busqueda", "%" + filtro + "%");

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);
            DgvHistoria.DataSource = table;
            DgvHistoria.Columns["Id_mantenimiento"].Visible = true;
            con.Close();
        }
    }
}
