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
            Objeto.ValidarLetras(e);
            Objeto.ValidarSeparadores(e);
        }
        private void cargaDatos()
        {
            conexion = new clsConexion(); // <--- Creamos una instancia de la clase clsConexion
            MySqlConnection con = conexion.getConnection(); // <--- Obtenemos la conexión a la base de datos

            if (con != null)
            {
                string consulta = "SELECT ejemplar.Id_ejemplar,ejemplar.Estado,ejemplar.Nombre_dispositivo,ejemplar.Numero_inventario,laboratorios.Nombre_laboratorio,ejemplar.Id_dispositivo FROM laboratorios,ejemplar,dispositivo WHERE ejemplar.Estado = 1 AND ejemplar.Id_laboratorio = laboratorios.Id_laboratorios AND ejemplar.Id_dispositivo = dispositivo.Id_dispositivo";

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
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            string IdDispositivo = txtIdDispositivo.Text; // <--- Obtenemos el modelo del dispositivo    
            int IdLaboratorio = Convert.ToInt32(cmbLaboratorio.SelectedValue); // <--- Obtenemos el Id del tipo de mantenimiento seleccionado   
            string NombreInventario = txtNombreInventario.Text;
            string NumeroInventario = txtNumeroInventario.Text;
            string Estado = "1"; // <--- Estado 1 para indicar que el dispositivo está activo

            if (string.IsNullOrEmpty(IdDispositivo) || string.IsNullOrEmpty(NombreInventario) || string.IsNullOrEmpty(NumeroInventario) || cmbLaboratorio.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos antes de registrar un nuevo dispositivo.");
            }

            conexion = new clsConexion();
            MySqlConnection conn = conexion.getConnection(); //<--- Obtiene el metodo Conexion 
            string consultaValidacion = "SELECT COUNT(*) FROM dispositivo WHERE Id_dispositivo = @Id_dispositivo AND Estado = 1";
            MySqlCommand validarCmd = new MySqlCommand(consultaValidacion, conn);
            validarCmd.Parameters.AddWithValue("@Id_dispositivo", IdDispositivo);

            int existe = Convert.ToInt32(validarCmd.ExecuteScalar());

            if (existe == 0)
            {
                MessageBox.Show("El ID del modelo no existe. No existe en la base de datos");
                conn.Close();
                return;
            }
            string consulta = "INSERT INTO dispositivo (Id_modelo, Id_tipodispositivo, Estado) VALUES (@Id_modelo, @Id_tipodispositivo,@Estado)";
            MySqlCommand command = new MySqlCommand(consulta, conn); //<----Command 
            command.Parameters.AddWithValue("@Id_modelo", IdLaboratorio);
            command.Parameters.AddWithValue("@Id_tipodispositivo", NombreInventario);
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
    }
}
