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
    public partial class frmDispositivos : Form
    {
        private clsConexion conexion; // <--- Creamos un objeto de la clase clsConexion para poder conectarnos a la base de datos
        public frmDispositivos()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuPrincipal principal = new MenuPrincipal();
            principal.Show();   
        }
         private void frmDispositivos_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // <--- Con este metodo le quitamos al usuario la capacidad de mover conn el cursor el form 
            this.MaximizeBox = false; // <--- Quitamos la capacidad de hacerlo a tamaño completo la pantalla el form 
            cargaDatos();   // <--- Cargamos los datos 
            DgvDispositivos.EnableHeadersVisualStyles = false; // Necesario para que se apliquen los estilos personalizados
            DgvDispositivos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(47, 65, 86);
            DgvDispositivos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void cargaDatos()
        {
            conexion = new clsConexion();
            MySqlConnection con = conexion.getConnection();

            //Comprobamos que se conecto correctamente 

            if (con != null)
            {
                //Creamos la consulta 

                string consulta = "SELECT dispositivo.Id_dispositivo,dispositivo.Id_tipodispositivo,dispositivo.Id_modelo,dispositivo.Estado,tipodispositivo.Tipodispositivo AS Tipo_Dispositivo,modelos.modelo FROM dispositivo INNER JOIN tipodispositivo ON dispositivo.Id_tipodispositivo = tipodispositivo.Id_tipodispositivo INNER JOIN modelos ON dispositivo.Id_modelo = modelos.Id_modelo" +
                    " WHERE dispositivo.Estado = 1";

                //Creamos un adaptador 

                MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, con);

                //Creamos una datable 

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                //Asignamos el datatable al souce del datagrid 

                DgvDispositivos.DataSource = dataTable;

                DgvDispositivos.Columns["Id_dispositivo"].Visible = true;
                DgvDispositivos.Columns["Id_tipodispositivo"].Visible = false;
                DgvDispositivos.Columns["Id_modelo"].Visible = false;
                DgvDispositivos.Columns["Estado"].Visible = false; // <--- Ocultamos la columna de Estado por seguridad   
                DgvDispositivos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                string consulta2 = "SELECT * FROM tipodispositivo WHERE Estado = 1";
                MySqlDataAdapter adapter2 = new MySqlDataAdapter(consulta2, con);
                con.Close();

                DataTable dataTable2 = new DataTable();
                adapter2.Fill(dataTable2);

                cmbTipoDispositivo.DataSource = dataTable2;
                cmbTipoDispositivo.DisplayMember = "Tipodispositivo";
                cmbTipoDispositivo.ValueMember = "Id_tipodispositivo";
                cmbTipoDispositivo.SelectedIndex = -1;
                cmbTipoDispositivo.DropDownStyle = ComboBoxStyle.DropDownList;


                string consulta3 = "SELECT * FROM modelos WHERE Estado = 1";

                MySqlDataAdapter adapter3 = new MySqlDataAdapter(consulta3, con);
                con.Close();

                DataTable dataTable3 = new DataTable();
                adapter3.Fill(dataTable3);

                cmbModelo.DataSource = dataTable3;
                cmbModelo.DisplayMember = "modelo";
                cmbModelo.ValueMember = "Id_modelo";
                cmbModelo.SelectedIndex = -1;
                cmbModelo.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            else
            {
                MessageBox.Show("Error al conectar");
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int IdModelo = Convert.ToInt32(cmbModelo.SelectedValue);
            int IdTipoDispositivo = Convert.ToInt32(cmbTipoDispositivo.SelectedValue);
            
            string Estado = "1";

            if(cmbModelo.SelectedIndex == -1 || cmbTipoDispositivo.SelectedIndex == -1 )
            {
                MessageBox.Show("Datos sin Llenar.", "Error");
                return;
            }
            else
            {
                conexion = new clsConexion();
                MySqlConnection conn = conexion.getConnection();

                string consulta = "INSERT INTO dispositivo (Id_tipodispositivo, Id_modelo, Estado) VALUES (@Id_tipodispositivo, @Id_modelo, @Estado)";
                MySqlCommand command = new MySqlCommand(consulta, conn);

                command.Parameters.AddWithValue("@Id_tipodispositivo", IdTipoDispositivo);
                command.Parameters.AddWithValue("@Id_modelo", IdModelo);
                command.Parameters.AddWithValue("@Estado", Estado);
                int filasAfectadas = command.ExecuteNonQuery();
                conn.Close();

                try
                {
                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Registro exitoso...");
                        cargaDatos();
                    }
                    else
                    {
                        MessageBox.Show("Algo anda mal...");
                    }
                }
                catch
                {
                    MessageBox.Show("Error al registrar el diagnóstico. Verifica que todos los campos sean válidos.");
                }
            }

        }
    }
}
