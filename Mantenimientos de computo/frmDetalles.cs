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
        private void cargaDatos()
        {
            conexion = new clsConexion(); // <--- Creamos una instancia de la clase clsConexion
            MySqlConnection con = conexion.getConnection(); // <--- Obtenemos la conexión a la base de datos
            
            if (con != null)
            {
                string consulta = "SELECT dispositivo.Estado,dispositivo.Id_dispositivo,tipodispositivo.Tipodispositivo,modelos.modelo FROM dispositivo,tipodispositivo,modelos WHERE dispositivo.Estado = 1 AND dispositivo.Id_tipodispositivo = tipodispositivo.Id_tipodispositivo AND dispositivo.Id_modelo = modelo.Id_modelo";
                //Creamos un adaptador 

                MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, con);

                //Creamos una datable 

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                //Asignamos el datatable al souce del datagrid 

                DgvDispositivo.DataSource = dataTable;

                DgvDispositivo.Columns["Id_dispositivo"].Visible = true;
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
    }
}
