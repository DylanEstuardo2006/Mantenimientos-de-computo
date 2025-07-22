using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Mantenimientos_de_computo
{
    public partial class frmDiagnosticos : Form
    {
        private Validaciones Objeto = new Validaciones();
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
            DgvDiagnosticos.EnableHeadersVisualStyles = false; // Necesario para que se apliquen los estilos personalizados
            DgvDiagnosticos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(47, 65, 86);
            DgvDiagnosticos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
           
        }
        private void btnVolver_Click(object sender, EventArgs e) //
        {
            this.Hide();
            MenuPrincipal principal = new MenuPrincipal();
            principal.Show();
        }
        private void txtIdEjemplar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Objeto.ValidarNumeros(e); // <--- Validamos que solo se ingresen numeros en el textbox de Id Ejemplar
        }
        private void cargaDatos()
        {
            conexion = new clsConexion();
            MySqlConnection con = conexion.getConnection();

            //Comprobamos que se conecto correctamente 

            if (con != null)
            {
                //Creamos la consulta 

                string consulta = "SELECT diagnostico.Estado,diagnostico.Id_diagnostico,diagnostico.Fecha_diagnostico as Fecha_Diagnostico,diagnostico.Resumen_diagnostico as Resumen_Diagnostico,tecnicos.Nombre_tecnico,tipomantenimiento.Tipomantenimiento as Tipo_Mantenimiento,ejemplar.Nombre_dispositivo as Nombre_Ejemplar,diagnostico.Id_ejemplar,diagnostico.Id_tipomantenimiento,diagnostico.Id_tecnico  FROM diagnostico INNER JOIN tipomantenimiento ON diagnostico.Id_tipomantenimiento = tipomantenimiento.Id_tipomantenimiento INNER JOIN ejemplar ON  diagnostico.Id_ejemplar = ejemplar.Id_ejemplar INNER JOIN tecnicos ON diagnostico.Id_tecnico = tecnicos.Id_tecnico WHERE diagnostico.Estado = 1";

                //Creamos un adaptador 

                MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, con);

                //Creamos una datable 

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                //Asignamos el datatable al souce del datagrid 

                DgvDiagnosticos.DataSource = dataTable;

                DgvDiagnosticos.Columns["Id_diagnostico"].Visible = true;
                DgvDiagnosticos.Columns["Id_ejemplar"].Visible = false;
                DgvDiagnosticos.Columns["Id_tipomantenimiento"].Visible = false;
                DgvDiagnosticos.Columns["Id_tecnico"].Visible = false;
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


                string consulta3 = "SELECT * FROM tipomantenimiento WHERE Estado = 1";

                MySqlDataAdapter adapter3 = new MySqlDataAdapter(consulta3, con);
                con.Close();

                DataTable dataTable3 = new DataTable();
                adapter3.Fill(dataTable3);

                cmbTipoMantenimiento.DataSource = dataTable3;
                cmbTipoMantenimiento.DisplayMember = "Tipomantenimiento";
                cmbTipoMantenimiento.ValueMember = "Id_tipomantenimiento";
                cmbTipoMantenimiento.SelectedIndex = -1;
                cmbTipoMantenimiento.DropDownStyle = ComboBoxStyle.DropDownList;

                string consulta4 = "SELECT * FROM ejemplar WHERE Estado = 1";

                MySqlDataAdapter adapter4 = new MySqlDataAdapter(consulta4, con);
                con.Close();

                DataTable dataTable4 = new DataTable();
                adapter4.Fill(dataTable4);

                cmbEjemplar.DataSource = dataTable4;
                cmbEjemplar.DisplayMember = "Nombre_dispositivo";
                cmbEjemplar.ValueMember = "Id_ejemplar";
                cmbEjemplar.SelectedIndex = -1;
                cmbEjemplar.DropDownStyle = ComboBoxStyle.DropDownList;

                
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
            int IdEjemplar = Convert.ToInt32(cmbEjemplar.SelectedValue);
            int IdTecnico = Convert.ToInt32(cmbTecnico.SelectedValue);
            int IdTipoMantenimiento = Convert.ToInt32(cmbTipoMantenimiento.SelectedValue);
            string ResumenDiagnostico = RtbResumenDiagnostico.Text;
            string Estado = "1";

            // Validación de campos
            if (FechaSeleccionada == DateTimePicker.MinimumDateTime || FechaSeleccionada < new DateTime(1900, 1, 1) || FechaSeleccionada > DateTime.Now.AddYears(100) || cmbEjemplar.SelectedIndex == -1 || cmbTecnico.SelectedIndex == -1 || cmbTipoMantenimiento.SelectedIndex == -1)
            {
                MessageBox.Show("Faltan casillas por llenar o la Fecha es incoherente");
            }
            else
            {
                // Obtener el Id del ejemplar desde el ComboBox usando ItemCombo
              

                conexion = new clsConexion();
                MySqlConnection conn = conexion.getConnection();

                string consulta = "INSERT INTO diagnostico (Fecha_diagnostico, Resumen_diagnostico, Id_tecnico, Id_tipomantenimiento, Id_ejemplar, Estado) " +
                                  "VALUES (@Fecha_diagnostico, @Resumen_diagnostico, @Id_tecnico, @Id_tipomantenimiento, @Id_ejemplar, @Estado)";

                MySqlCommand command = new MySqlCommand(consulta, conn);
                command.Parameters.AddWithValue("@Fecha_diagnostico", FechaSeleccionada);
                command.Parameters.AddWithValue("@Resumen_diagnostico", ResumenDiagnostico);
                command.Parameters.AddWithValue("@Id_tecnico", IdTecnico);
                command.Parameters.AddWithValue("@Id_tipomantenimiento", IdTipoMantenimiento);
                command.Parameters.AddWithValue("@Id_ejemplar", IdEjemplar);
                command.Parameters.AddWithValue("@Estado", Estado);

                try
                {
                    int filasAfectadas = command.ExecuteNonQuery();
                    conn.Close();

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

                // Limpiar campos
                cmbTecnico.SelectedIndex = -1;
                cmbTipoMantenimiento.SelectedIndex = -1;
                RtbResumenDiagnostico.Text = "";
                cmbEjemplar.SelectedIndex = -1;
            }


        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBusqueda.Text;
            conexion = new clsConexion();

            MySqlConnection con = conexion.getConnection();

            string consulta = "SELECT diagnostico.Id_diagnostico,diagnostico.Fecha_diagnostico as Fecha_Diagnostico,diagnostico.Resumen_diagnostico as Resumen_Diagnostico,tipomantenimiento.Tipomantenimiento as Tipo_Mantenimiento,ejemplar.Nombre_dispositivo as Nombre_Ejemplar FROM diagnostico INNER JOIN tipomantenimiento ON diagnostico.Id_tipomantenimiento = tipomantenimiento.Id_tipomantenimiento INNER JOIN ejemplar ON diagnostico.Id_ejemplar = ejemplar.Id_ejemplar WHERE diagnostico.Estado = 1 AND (diagnostico.Fecha_diagnostico LIKE @busqueda OR tipomantenimiento.Tipomantenimiento LIKE @busqueda OR ejemplar.Nombre_dispositivo LIKE @busqueda)";

            MySqlCommand command = new MySqlCommand(consulta, con);
            command.Parameters.AddWithValue("@busqueda", "%" + filtro + "%");

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);
            DgvDiagnosticos.DataSource = table;
            DgvDiagnosticos.Columns["Id_diagnostico"].Visible = true;
            con.Close();

        }
      
        private void DgvDiagnosticos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = DgvDiagnosticos.Rows[e.RowIndex];
                DateTime fecha = Convert.ToDateTime(fila.Cells["Fecha_diagnostico"].Value);
                DtmFechaDiagnostico.Value = fecha;
                cmbEjemplar.Text = fila.Cells["Nombre_Ejemplar"].Value?.ToString();
                cmbTecnico.Text = fila.Cells["Nombre_tecnico"].Value?.ToString();
                cmbTipoMantenimiento.Text = fila.Cells["Tipo_Mantenimiento"].Value?.ToString();
                RtbResumenDiagnostico.Text = fila.Cells["Resumen_diagnostico"].Value?.ToString();

                lblIDDiagnostico.Text = fila.Cells["Id_diagnostico"].Value.ToString();

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        { 
            if(string.IsNullOrWhiteSpace(lblIDDiagnostico.Text))
            {
                MessageBox.Show("No se ha escogido ningun valor a eliminar");
                return;
            }
            string Estado = "0";
            int IdDiagnostico = Convert.ToInt32(lblIDDiagnostico.Text);
           
            DialogResult result = MessageBox.Show("En verdad quieres eliminar el registro con el Id:" + IdDiagnostico + "?"
                  , "Eliminar", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                return;
            }
            conexion = new clsConexion();
            MySqlConnection con = conexion.getConnection();

          

            string consulta;
            MySqlCommand command;
            consulta = "UPDATE diagnostico SET Estado=@Estado WHERE Id_diagnostico=@Id_diagnostico"; //<----- En este apartado hacemos una eliminación logica y no Física, evitamos un mensaje de error 
            command = new MySqlCommand(consulta, con);
         

            command.Parameters.AddWithValue("@Estado", Estado);
            command.Parameters.AddWithValue("@Id_diagnostico", IdDiagnostico);

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
            cmbEjemplar.Text = "";
            cmbTecnico.Text = "";
            cmbTipoMantenimiento.Text ="";
            RtbResumenDiagnostico.Clear();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(lblIDDiagnostico.Text))
                {
                    MessageBox.Show("Porfavor seleccione un tecnico de la tabla para actualizar sus datos");
                    return; // <--- Si no hay un tecnico seleccionado, se sale del metodo
                }
                //En este apartado obtenemos los datos de las cajas de texto 
                int IdDiagnostico = Convert.ToInt32(lblIDDiagnostico.Text);
                DateTime FechaSeleccionada = DtmFechaDiagnostico.Value;
                int IdEjemplar = Convert.ToInt32(cmbEjemplar.SelectedValue);
                int IdTecnico = Convert.ToInt32(cmbTecnico.SelectedValue); // <--- Obtenemos el Id del tecnico seleccionado
                int IdTipoMantenimiento = Convert.ToInt32(cmbTipoMantenimiento.SelectedValue); // <--- Obtenemos el Id del tipo de mantenimiento seleccionado   
                string ResumenDiagnostico = RtbResumenDiagnostico.Text;

                conexion = new clsConexion();
                MySqlConnection con = conexion.getConnection();

                string consulta;
                MySqlCommand command;

                if (FechaSeleccionada == DateTimePicker.MinimumDateTime || FechaSeleccionada < new DateTime(1900, 1, 1) || FechaSeleccionada > DateTime.Now.AddYears(100) || cmbEjemplar.SelectedIndex == -1 || cmbTecnico.SelectedIndex == -1 || cmbTipoMantenimiento.SelectedIndex == -1)
                {
                    MessageBox.Show("Faltan casillas por llenar");

                }
                else
                {

                    consulta = "Update diagnostico set Fecha_diagnostico=@Fecha_diagnostico,Resumen_diagnostico=@Resumen_diagnostico,Id_tecnico=@Id_tecnico,Id_tipomantenimiento=@Id_tipomantenimiento,Id_ejemplar= @Id_ejemplar where Id_diagnostico=@Id_diagnostico";
                    command = new MySqlCommand(consulta, con);

                    command.Parameters.AddWithValue("@Fecha_diagnostico", FechaSeleccionada);
                    command.Parameters.AddWithValue("@Resumen_diagnostico", ResumenDiagnostico);
                    command.Parameters.AddWithValue("@Id_tecnico", IdTecnico);
                    command.Parameters.AddWithValue("@Id_tipomantenimiento", IdTipoMantenimiento);
                    command.Parameters.AddWithValue("@Id_ejemplar", IdEjemplar);
                    command.Parameters.AddWithValue("@Id_diagnostico", IdDiagnostico);




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
            catch
            {
                MessageBox.Show("Error al actualizar, porfavor seleccione alguno de los datos que aparecen en la tabla");
            }

            // En este apartado las cajas se limpian inmediatamente de haber echo la operación 
            cmbTecnico.SelectedIndex = -1; // <--- Limpiamos el combobox de Tecnicos    
            cmbTipoMantenimiento.SelectedIndex = -1; // <--- Limpiamos el combobox de Tipos de Mantenimiento
            RtbResumenDiagnostico.Text = ""; // <--- Limpiamos el richtextbox de Resumen Diagnostico
            cmbEjemplar.SelectedIndex = -1; // <--- Limpiamos el textbox de Id Ejemplar
        }

    }
}