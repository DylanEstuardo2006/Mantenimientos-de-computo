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
    public partial class frmMarcas : Form
    {
        private clsConexion conexion;
        public frmMarcas()
        {
            InitializeComponent();
        }

        private void frmMarcas_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            cargaDatos();
            DgvMarcas.EnableHeadersVisualStyles = false; // Necesario para que se apliquen los estilos personalizados
            DgvMarcas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(47, 65, 86);
            DgvMarcas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DgvMarcas.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold); // Fuente opcional
        }
        private void cargaDatos()
        {
            conexion = new clsConexion();
            MySqlConnection con = conexion.getConnection();

            //Comprobamos que se conecto correctamente 

            if (con != null)
            {
                //Creamos la consulta 

                string consulta = "SELECT marca.Id_marca,marca.marca,marca.Estado FROM marca where Estado = 1";

                //Creamos un adaptador 

                MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, con);

                //Creamos una datable 

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                //Asignamos el datatable al souce del datagrid 

                DgvMarcas.DataSource = dataTable;

                DgvMarcas.Columns["Id_marca"].Visible = false;
                DgvMarcas.Columns["Estado"].Visible = false; // <--- Ocultamos la columna de Estado por seguridad   
                DgvMarcas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                MessageBox.Show("Error al conectar");
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string marcaNombre = txtMarcas.Text.Trim();

            if (string.IsNullOrWhiteSpace(marcaNombre))
            {
                MessageBox.Show("Por favor ingresa un nombre de marca válido.", "Validación");
                return;
            }

            try
            {
                using (MySqlConnection conn = conexion.getConnection())
                {
                    string Estado = "1";
                    string query = "INSERT INTO marca (marca, Estado) VALUES (@marca,@Estado)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@marca", marcaNombre);
                    cmd.Parameters.AddWithValue("Estado", Estado);


                    int resultado = cmd.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        MessageBox.Show("Marca registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMarcas.Clear();
                        // Si tienes algún componente que se actualiza con las marcas, puedes llamarlo aquí.
                        cargaDatos();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo registrar la marca.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBusqueda.Text;
            conexion = new clsConexion();
            MySqlConnection con = conexion.getConnection();

            string consulta = "SELECT marca.Id_marca, marca.marca, marca.Estado FROM marca WHERE (marca.marca LIKE @busqueda) AND marca.Estado = 1";
            MySqlCommand command = new MySqlCommand(consulta, con);
            command.Parameters.AddWithValue("@busqueda", "%" + filtro + "%");

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);
            DgvMarcas.DataSource = table;
            DgvMarcas.Columns["Id_marca"].Visible = false;
            DgvMarcas.Columns["Estado"].Visible = false;
            con.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(lblIDMarcas.Text))
                {
                    MessageBox.Show("Selecciona una marca antes de eliminar");
                    return;
                }
                else
                {
                    MessageBox.Show("ID a eliminar: " + lblIDMarcas.Text);
                }

                string Estado = "0";
                int IdMarca = Convert.ToInt32(lblIDMarcas.Text); // Conversión directa

                conexion = new clsConexion();
                MySqlConnection con = conexion.getConnection();

                if (con != null)
                {
                    string consulta = "UPDATE marca SET Estado = @Estado WHERE Id_marca = @Id_marca";
                    MySqlCommand command = new MySqlCommand(consulta, con);

                    command.Parameters.AddWithValue("@Estado", Estado);
                    command.Parameters.AddWithValue("@Id_marca", IdMarca);

                    int filasAfectadas = command.ExecuteNonQuery();
                    con.Close();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Marca eliminada correctamente.");
                        cargaDatos(); // Refrescar tabla
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar la marca.");
                    }

                    // Limpiar campos
                    txtMarcas.Text = "";
                    lblIDMarcas.Text = "";
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblIDMarcas.Text))
            {
                MessageBox.Show("Ingrese un valor de la tabla antes de actualizar");
            }
            //En este apartado obtenemos los datos de las cajas de texto 
            string Nombre = txtMarcas.Text;
            string IdMarca = lblIDMarcas.Text;
            conexion = new clsConexion();
            MySqlConnection con = conexion.getConnection();

            if (string.IsNullOrEmpty(Nombre))
            {
                MessageBox.Show("Faltan casillas por llenar");
            }
            else
            {
                string consulta = "UPDATE marca SET marca=@marca WHERE Id_marca=@Id_marca";
                MySqlCommand command = new MySqlCommand(consulta, con);

                command.Parameters.AddWithValue("@marca", Nombre);
                command.Parameters.AddWithValue("@Id_marca", IdMarca);
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
            txtMarcas.Text = "";

        }

        private void DgvMarcas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = DgvMarcas.Rows[e.RowIndex];
                txtMarcas.Text = fila.Cells["marca"].Value?.ToString();
                lblIDMarcas.Text = fila.Cells["Id_marca"].Value?.ToString();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuPrincipal principal = new MenuPrincipal();
            principal.Show();   
        }
    }
}
