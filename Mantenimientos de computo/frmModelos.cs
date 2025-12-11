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
            dgvModelos.EnableHeadersVisualStyles = false; // Necesario para que se apliquen los estilos personalizados
            dgvModelos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(47, 65, 86);
            dgvModelos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
      

            cargaDatos();
 
        }
        private void cargaDatos()
        {
            conexion = new clsConexion();
            MySqlConnection con = conexion.getConnection();

            //Comprobamos que se conecto correctamente 

            if (con != null)
            {
                //Creamos la consulta 

                string consulta = " SELECT modelos.idModelo,modelos.modelos,marca.marcas,marca.idMarcas FROM modelos,marca WHERE modelos.idMarca = marca.idMarcas";
                //Creamos un adaptador 

                MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, con);

                //Creamos una datable 

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                //Asignamos el datatable al souce del datagrid 

                dgvModelos.DataSource = dataTable;
                dgvModelos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                string marcas = "SELECT marca.idMarcas,marca.marcas FROM marca";

                MySqlDataAdapter marcasAdapter = new MySqlDataAdapter(marcas, con);

                DataTable marcarCombo = new DataTable();
                marcasAdapter.Fill(marcarCombo);
                
                cmbMarcas.DataSource = marcarCombo;
                cmbMarcas.DisplayMember = "marcas";
                cmbMarcas.ValueMember = "idMarcas";
                cmbMarcas.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Error al conectar");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que se haya seleccionado un modelo
                if (string.IsNullOrWhiteSpace(lblIdModelo.Text))
                {
                    MessageBox.Show("Seleccione un modelo antes de actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar que se haya ingresado el nombre del modelo
                if (string.IsNullOrWhiteSpace(txtModelo.Text))
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
                int IdModelo = Convert.ToInt32(lblIdModelo.Text);
                string nombreModelo = txtModelo.Text.Trim();
                int idMarca = Convert.ToInt32(cmbMarcas.SelectedValue);

                // Inicializar conexión
                conexion = new clsConexion();
                MySqlConnection con = conexion.getConnection();

                if (con != null)
                {
                    // Consulta SQL para actualizar
                    string consulta = @"UPDATE modelos 
                                SET modelos = @modelos, idMarca = @idMarca
                                WHERE idModelo = @idModelo";

                    MySqlCommand command = new MySqlCommand(consulta, con);
                    command.Parameters.AddWithValue("@modelos", nombreModelo);
                    command.Parameters.AddWithValue("@idMarca", idMarca);
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
                    txtModelo.Clear();
                    cmbMarcas.SelectedIndex = -1;
                    lblIdModelo.Text = "";
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
                DataGridViewRow row = dgvModelos.Rows[e.RowIndex];

                // Asignar marca al ComboBox
                cmbMarcas.Text = row.Cells["marcas"].Value?.ToString();
                // Asignar modelo al TextBox
                txtModelo.Text = row.Cells["modelos"].Value?.ToString();
                // Asignar ID del modelo al Label oculto
                lblIdModelo.Text = row.Cells["idModelo"].Value.ToString();
            }
        }

        private void cmbMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validar que se haya seleccionado una marca y que el modelo no esté vacío
            if (cmbMarcas.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtModelo.Text))
            {
                MessageBox.Show("Debe seleccionar una marca y escribir un modelo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string modelo = txtModelo.Text.Trim();
            int idMarca = Convert.ToInt32(cmbMarcas.SelectedValue);

            try
            {
                using (MySqlConnection conn = conexion.getConnection())
                {
                    string query = "INSERT INTO modelos (modelos,idMarca) VALUES (@modelos, @idMarca)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@modelos", modelo);
                    cmd.Parameters.AddWithValue("@idMarca", idMarca);

                    int resultado = cmd.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        MessageBox.Show("Modelo registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtModelo.Clear();
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
                if (string.IsNullOrWhiteSpace(lblIdModelo.Text))
                {
                    MessageBox.Show("Seleccione un modelo antes de eliminar.");
                    return;

                }
                else
                {
                    MessageBox.Show("ID a eliminar: " + lblIdModelo.Text);


                }

               
                int IdModelo = Convert.ToInt32(lblIdModelo.Text);

                // Inicializamos conexión
                conexion = new clsConexion();
                MySqlConnection con = conexion.getConnection();

                if (con != null)
                {
                    // Consulta para eliminación lógica
                    string consulta = "DELETE FROM modelos WHERE idModelos = @idModelos";
                    MySqlCommand command = new MySqlCommand(consulta, con);

                    // Asignamos parámetros
                    command.Parameters.AddWithValue("@idModelos", IdModelo);

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
                    txtModelo.Text = "";
                    cmbMarcas.SelectedIndex = -1;
                    lblIdModelo.Text = "";
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
            string filtro = txtBuscar.Text;
            conexion = new clsConexion();
            MySqlConnection con = conexion.getConnection();

            // Consulta para buscar por nombre de modelo o marca
            string consulta = @"
     SELECT modelos.idModelo,
           modelos.modelos,
           marca.marcas
    FROM modelos
    INNER JOIN marca ON modelos.idMarca = marca.idMarcas
    WHERE (modelos.modelos LIKE @busqueda
        OR marca.marcas LIKE @busqueda)";

            MySqlCommand command = new MySqlCommand(consulta, con);
            command.Parameters.AddWithValue("@busqueda", "%" + filtro + "%");

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);
            dgvModelos.DataSource = table;

            con.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuPrincipal principal = new MenuPrincipal();
            principal.Show();
        }

        private void LblIngresMarca_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
