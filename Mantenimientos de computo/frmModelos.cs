using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mantenimientos_de_computo
{
    public partial class frmModelos : Form
    {
        private clsConexion conexion;
        public frmModelos()
        {
            InitializeComponent();
        }

        private void frmModelos_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // <--- Con este metodo le quitamos al usuario la capacidad de mover conn el cursor el form 
            this.MaximizeBox = false; // <--- Quitamos la capacidad de hacerlo a tamaño completo la pantalla el form 
            cmbMarcas.DropDownStyle = ComboBoxStyle.DropDownList;
            DgvModelos.EnableHeadersVisualStyles = false; // Necesario para que se apliquen los estilos personalizados
            DgvModelos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(47, 65, 86);
            DgvModelos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DgvModelos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold); // Fuente opcional

            cargaDatos();
            CargarMarcas();
        }
        private void cargaDatos()
        {
            conexion = new clsConexion();
            MySqlConnection con = conexion.getConnection();

            //Comprobamos que se conecto correctamente 

            if (con != null)
            {
                //Creamos la consulta 

                string consulta = " SELECT m.Id_modelo,m.modelo, m.Estado, mar.Marca FROM modelos AS m INNER JOIN marca AS mar ON m.Id_marca = mar.Id_marca WHERE m.Estado = 1;";

                //Creamos un adaptador 

                MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, con);

                //Creamos una datable 

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                //Asignamos el datatable al souce del datagrid 

                DgvModelos.DataSource = dataTable;

                DgvModelos.Columns["Id_modelo"].Visible = true;
                DgvModelos.Columns["Estado"].Visible = false; // <--- Ocultamos la columna de Estado por seguridad   
                DgvModelos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                MessageBox.Show("Error al conectar");
            }
        }
        private void CargarMarcas()
        {
            try
            {
                conexion = new clsConexion();
                MySqlConnection con = conexion.getConnection();

                if (con != null)
                {
                    string consulta = "SELECT Id_marca, Marca FROM marca WHERE Estado = 1";
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, con);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    // Enlaza al ComboBox
                    cmbMarcas.DataSource = tabla;
                    cmbMarcas.DisplayMember = "Marca";
                    cmbMarcas.ValueMember = "Id_marca";
                    cmbMarcas.SelectedIndex = -1; // No seleccionar nada al inicio

                    con.Close();
                }
                else
                {
                    MessageBox.Show("Error al conectar con la base de datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar marcas: " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que se haya seleccionado un modelo
                if (string.IsNullOrWhiteSpace(lblIDModelos.Text))
                {
                    MessageBox.Show("Seleccione un modelo antes de actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar que se haya ingresado el nombre del modelo
                if (string.IsNullOrWhiteSpace(txtModelos.Text))
                {
                    MessageBox.Show("Ingrese el nombre del modelo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar que se haya seleccionado una marca
                if (cmbMarcas.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione una marca.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener los datos
                int IdModelo = Convert.ToInt32(lblIDModelos.Text);
                string nombreModelo = txtModelos.Text.Trim();
                int idMarca = Convert.ToInt32(cmbMarcas.SelectedValue);

                // Inicializar conexión
                conexion = new clsConexion();
                MySqlConnection con = conexion.getConnection();

                if (con != null)
                {
                    // Consulta SQL para actualizar
                    string consulta = @"UPDATE modelos 
                                SET modelo = @modelo, Id_marca = @Id_Marca 
                                WHERE Id_modelo = @idModelo";

                    MySqlCommand command = new MySqlCommand(consulta, con);
                    command.Parameters.AddWithValue("@modelo", nombreModelo);
                    command.Parameters.AddWithValue("@Id_Marca", idMarca);
                    command.Parameters.AddWithValue("@idModelo", IdModelo);

                    // Ejecutar consulta
                    int filasAfectadas = command.ExecuteNonQuery();
                    con.Close();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Modelo actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargaDatos(); // Refrescar datos en DataGridView
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el modelo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // Limpiar campos
                    txtModelos.Clear();
                    cmbMarcas.SelectedIndex = -1;
                    lblIDModelos.Text = "";
                }
                else
                {
                    MessageBox.Show("Error al conectar con la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvMarcas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DgvModelos.Rows[e.RowIndex];

                // Asignar marca al ComboBox
                cmbMarcas.Text = row.Cells["marca"].Value?.ToString();
                // Asignar modelo al TextBox
                txtModelos.Text = row.Cells["modelo"].Value?.ToString();
                // Asignar ID del modelo al Label oculto
                lblIDModelos.Text = row.Cells["Id_modelo"].Value.ToString();
            }
        }

        private void cmbMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validar que se haya seleccionado una marca y que el modelo no esté vacío
            if (cmbMarcas.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtModelos.Text))
            {
                MessageBox.Show("Debe seleccionar una marca y escribir un modelo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string modelo = txtModelos.Text.Trim();
            int idMarca = Convert.ToInt32(cmbMarcas.SelectedValue);

            try
            {
                using (MySqlConnection conn = conexion.getConnection())
                {
                    string query = "INSERT INTO modelos (modelo, Id_marca, Estado) VALUES (@modelo, @idMarca, 1)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@modelo", modelo);
                    cmd.Parameters.AddWithValue("@idMarca", idMarca);

                    int resultado = cmd.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        MessageBox.Show("Modelo registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtModelos.Clear();
                        cmbMarcas.SelectedIndex = -1;
                        // Si tienes un DataGridView, puedes recargarlo aquí (opcional)
                        // cargarModelos();
                        cargaDatos();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo registrar el modelo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                // Validación básica
                if (string.IsNullOrWhiteSpace(lblIDModelos.Text))
                {
                    MessageBox.Show("Seleccione un modelo antes de eliminar.");
                    return;

                }
                else
                {
                    MessageBox.Show("ID a eliminar: " + lblIDModelos.Text);


                }

                string Estado = "0"; // Estado 0 = Eliminación lógica (inactivo)
                int IdModelo = Convert.ToInt32(lblIDModelos.Text);

                // Inicializamos conexión
                conexion = new clsConexion();
                MySqlConnection con = conexion.getConnection();

                if (con != null)
                {
                    // Consulta para eliminación lógica
                    string consulta = "UPDATE modelos SET Estado = @Estado WHERE Id_modelo = @Id_modelo";
                    MySqlCommand command = new MySqlCommand(consulta, con);

                    // Asignamos parámetros
                    command.Parameters.AddWithValue("@Estado", Estado);
                    command.Parameters.AddWithValue("@Id_modelo", IdModelo);

                    // Ejecutamos la consulta
                    int filasAfectadas = command.ExecuteNonQuery();
                    con.Close();

                    // Verificamos resultado
                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Modelo eliminado correctamente.");
                        cargaDatos(); // Refrescar datos en la tabla
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el modelo.");
                    }

                    // Limpiar campos
                    txtModelos.Text = "";
                    cmbMarcas.SelectedIndex = -1;
                    lblIDModelos.Text = "";
                }
                else
                {
                    MessageBox.Show("Error al conectar con la base de datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBusqueda.Text;
            conexion = new clsConexion();
            MySqlConnection con = conexion.getConnection();

            // Consulta para buscar por nombre de modelo o marca
            string consulta = @"
             SELECT m.Id_modelo, m.modelo, ma.marca AS Marca, m.Estado 
             FROM modelos m 
             INNER JOIN marca ma ON m.Id_marca = ma.Id_marca 
             WHERE (m.modelo LIKE @busqueda OR ma.marca LIKE @busqueda) 
             AND m.Estado = 1";

            MySqlCommand command = new MySqlCommand(consulta, con);
            command.Parameters.AddWithValue("@busqueda", "%" + filtro + "%");

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);
            DgvModelos.DataSource = table;
            DgvModelos.Columns["Id_modelo"].Visible = false;
            DgvModelos.Columns["Estado"].Visible = false;

            con.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuPrincipal principal = new MenuPrincipal();
            principal.Show();
        }
    }
}
