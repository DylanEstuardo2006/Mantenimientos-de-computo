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
    public partial class frmDiagnosticos : Form
    {
        private clsConexion conexion; // <----- Creamos la conexión privada 
        public frmDiagnosticos()
        {
            InitializeComponent();
        }

        private void frmDiagnosticos_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // <--- Con este metodo le quitamos al usuario la capacidad de mover conn el cursor el form 
            this.MaximizeBox = false; // <--- Quitamos la capacidad de hacerlo a tamaño completo la pantalla el form 
            cargaDatos();   // <--- Cargamos los datos 
        }
        private void btnVolver_Click(object sender, EventArgs e) //
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

               string consulta = "SELECT diagnostico.Estado,diagnostico.Id_diagnostico,diagnostico.Fecha_diagnostico,diagnostico.Resumen_diagnostico,tecnicos.Nombre_tecnico,tipomantenimiento.Tipomantenimiento,ejemplar.Nombre_dispositivo From diagnostico,ejemplar,tecnicos,tipomantenimiento where diagnostico.Estado = 1 AND diagnostico.Id_tecnico = tecnicos.Id_tecnico AND diagnostico.Id_tipomantenimiento = tipomantenimiento.Id_tipomantenimiento AND diagnostico.Id_ejemplar = ejemplar.Id_ejemplar";

                //Creamos un adaptador 

                MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, con);

                //Creamos una datable 

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                //Asignamos el datatable al souce del datagrid 

                DgvDiagnosticos.DataSource = dataTable; 

                DgvDiagnosticos.Columns["Id_diagnostico"].Visible = false;
                DgvDiagnosticos.Columns["Estado"].Visible = false; // <--- Ocultamos la columna de Estado por seguridad   
                DgvDiagnosticos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                string consulta2 = "SELECT * FROM tecnicos where Estado = 1";
                MySqlDataAdapter adapter2 = new MySqlDataAdapter(consulta2, con);
                con.Close();

                DataTable dataTable2 = new DataTable();
                adapter2.Fill(dataTable2);

                cmbTecnico.DataSource = dataTable2;
                cmbTecnico.DisplayMember = "Nombre_tecnico";
                cmbTecnico.ValueMember = "Id_tecnico";

                string consulta3 = "SELECT * FROM tipomantenimiento";

                MySqlDataAdapter adapter3 = new MySqlDataAdapter(consulta3, con);
                con.Close();

                DataTable dataTable3 = new DataTable();
                adapter3.Fill(dataTable3);

                cmbTipoMantenimiento.DataSource = dataTable3;
                cmbTipoMantenimiento.DisplayMember = "Tipomantenimiento";
                cmbTipoMantenimiento.ValueMember = "Id_tipomantenimiento";
            }
            else
            {
                MessageBox.Show("Error al conectar");
            }
        }
        // Botón Volver 
        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal principal = new MenuPrincipal();
            principal.Show();
        }
    }
}
