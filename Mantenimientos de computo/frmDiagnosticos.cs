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

               string consulta = "SELECT diagnostico.Estado,diagnostico.Id_diagnostico,diagnostico.Fecha_diagnostico,diagnostico.Resumen_diagnostico,tecnicos.Nombre_tecnico,tipomantenimiento.Tipomantenimiento,ejemplar.Id_ejemplar From diagnostico,ejemplar,tecnicos,tipomantenimiento where diagnostico.Estado = 1 AND diagnostico.Id_tecnico = tecnicos.Id_tecnico AND diagnostico.Id_tipomantenimiento = tipomantenimiento.Id_tipomantenimiento AND diagnostico.Id_ejemplar = ejemplar.Id_ejemplar";

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
                cmbTecnico.SelectedIndex = -1;
                cmbTecnico.DropDownStyle = ComboBoxStyle.DropDownList;


                string consulta3 = "SELECT * FROM tipomantenimiento";

                MySqlDataAdapter adapter3 = new MySqlDataAdapter(consulta3, con);
                con.Close();

                DataTable dataTable3 = new DataTable();
                adapter3.Fill(dataTable3);

                cmbTipoMantenimiento.DataSource = dataTable3;
                cmbTipoMantenimiento.DisplayMember = "Tipomantenimiento";
                cmbTipoMantenimiento.ValueMember = "Id_tipomantenimiento";
                cmbTipoMantenimiento.SelectedIndex = -1;
                cmbTipoMantenimiento.DropDownStyle = ComboBoxStyle.DropDownList;
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            DateTime FechaSeleccionada = DtmFechaDiagnostico.Value;
            string IdEjemplar = txtIdEjemplar.Text;
            int IdTecnico = Convert.ToInt32(cmbTecnico.SelectedValue); // <--- Obtenemos el Id del tecnico seleccionado
            int IdTipoMantenimiento = Convert.ToInt32(cmbTipoMantenimiento.SelectedValue); // <--- Obtenemos el Id del tipo de mantenimiento seleccionado   
            string ResumenDiagnostico = RtbResumenDiagnostico.Text;
            string Estado = "1"; // <----- Constante que permite Poner el estado de el usuario como activo o negativo 

            //En este if validamos con el IsNullOrEmpty para evitar que si el usuario no ingresa algun campo le salga un mensaje de faltan casillas por llenar 

            if (FechaSeleccionada == DateTimePicker.MinimumDateTime || FechaSeleccionada < new DateTime(1900, 1, 1) || FechaSeleccionada > DateTime.Now.AddYears(100) || string.IsNullOrEmpty(IdEjemplar) || cmbTecnico.SelectedIndex == -1 || cmbTipoMantenimiento.SelectedIndex == -1)
            {
                MessageBox.Show("Faltan casillas por llenar");

            }
            else
            {
                conexion = new clsConexion();
                MySqlConnection conn = conexion.getConnection(); //<--- Obtiene el metodo Conexion 

                //Insertar los valores 
                string consulta = "INSERT INTO diagnostico (Fecha_diagnostico,Resumen_diagnostico,Id_tecnico,Id_tipomantenimiento,Id_ejemplar,Estado)" +
                  "VALUES (@Fecha_diagnostico,@Resumen_diagnostico,@Id_tecnico,@Id_tipomantenimiento,@Id_ejemplar,@Estado)";

                MySqlCommand command = new MySqlCommand(consulta, conn); //<----Command 
                command.Parameters.AddWithValue("@Fecha_diagnostico", FechaSeleccionada );
                command.Parameters.AddWithValue("@Resumen_diagnostico", ResumenDiagnostico);
                command.Parameters.AddWithValue("@Id_tecnico", IdTecnico);
                command.Parameters.AddWithValue("@Id_tipomantenimiento", IdTipoMantenimiento);
                command.Parameters.AddWithValue("@Id_ejemplar", IdEjemplar);
                command.Parameters.AddWithValue("@Estado", Estado); // <--- Estado por defecto al registrar un técnico
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
           

        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {

        }

        private void DgvDiagnosticos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = DgvDiagnosticos.Rows[e.RowIndex];
                DateTime fecha = Convert.ToDateTime(fila.Cells["Fecha_diagnostico"].Value);
                DtmFechaDiagnostico.Value = fecha;
                txtIdEjemplar.Text = fila.Cells["Id_ejemplar"].Value?.ToString();
                cmbTecnico.Text = fila.Cells["Nombre_tecnico"].Value?.ToString();
                cmbTipoMantenimiento.Text = fila.Cells["Tipomantenimiento"].Value?.ToString();
                RtbResumenDiagnostico.Text = fila.Cells["Resumen_diagnostico"].Value?.ToString();

                lblIDDiagnostico.Text = fila.Cells["Id_diagnostico"].Value.ToString();

            }
        }
    }
}

