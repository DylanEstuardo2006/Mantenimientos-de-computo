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
            DgvMarcas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 136, 62);
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

                string consulta = "SELECT marca.idMarcas,marca.marcas FROM marca";

                //Creamos un adaptador 

                MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, con);

                //Creamos una datable 

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                //Asignamos el datatable al souce del datagrid 

                DgvMarcas.DataSource = dataTable;
                DgvMarcas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                MessageBox.Show("Error al conectar");
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string marcaNombre = txtMarca.Text;

            if (string.IsNullOrWhiteSpace(marcaNombre))
            {
                MessageBox.Show("Por favor ingresa un nombre de marca válido.", "Validación");
                return;
            }
            try
            {
                using (MySqlConnection conn = conexion.getConnection())
                {
                    string query = "INSERT INTO marca (marcas) VALUES (@marcas)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@marcas", marcaNombre);
                   

                    int resultado = cmd.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        MessageBox.Show("Marca registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMarca.Text = "";
                        txtEliminar.Text = "";
                        txtBuscar.Text = "";
                        lblIdMarca.Text = "";
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
            string filtro = txtBuscar.Text;
            conexion = new clsConexion();
            MySqlConnection con = conexion.getConnection();

            string consulta = "SELECT marca.idMarcas, marca.marcas FROM marca WHERE marca.marcas LIKE @busqueda";
            MySqlCommand command = new MySqlCommand(consulta, con);
            command.Parameters.AddWithValue("@busqueda", "%" + filtro + "%");

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);
            DgvMarcas.DataSource = table;
            con.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string marcas = txtMarca.Text;
                if (string.IsNullOrWhiteSpace(lblIdMarca.Text))
                {
                    MessageBox.Show("Selecciona una marca antes de eliminar");
                    return;
                }
                else
                {
                    MessageBox.Show("Desea Eliminar " + marcas);
                }

             
                int IdMarca = Convert.ToInt32(lblIdMarca.Text); // Conversión directa

                conexion = new clsConexion();
                MySqlConnection con = conexion.getConnection();

                if (con != null)
                {
                    string consulta = "DELETE FROM marca SET  WHERE idMarcas = @idMarcas";
                    MySqlCommand command = new MySqlCommand(consulta, con);

                    command.Parameters.AddWithValue("@idMarcas", IdMarca);

                    int filasAfectadas = command.ExecuteNonQuery();
                    con.Close();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Marca eliminada correctamente.");
                        txtMarca.Text = "";
                        txtEliminar.Text = "";
                        txtBuscar.Text = "";
                        lblIdMarca.Text= "";
                        cargaDatos(); // Refrescar tabla
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar la marca.");
                    }
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
            if (string.IsNullOrEmpty(lblIdMarca.Text))
            {
                MessageBox.Show("Ingrese un valor de la tabla antes de actualizar");
            }
            //En este apartado obtenemos los datos de las cajas de texto 
            string nombre = txtMarca.Text;
            string IdMarca = lblIdMarca.Text;
         
            conexion = new clsConexion();
            MySqlConnection con = conexion.getConnection();

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Faltan casillas por llenar");
            }
            else
            {
                string consulta = "UPDATE marca SET marcas=@marcas WHERE idMarcas=@idMarcas";
                MySqlCommand command = new MySqlCommand(consulta, con);

                command.Parameters.AddWithValue("@marcas", nombre);
                command.Parameters.AddWithValue("@idMarcas", IdMarca);
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
            txtMarca.Text = "";
            txtEliminar.Text = "";
            txtBuscar.Text = "";
        }

        private void DgvMarcas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = DgvMarcas.Rows[e.RowIndex];
                txtMarca.Text = fila.Cells["marcas"].Value?.ToString();
                txtEliminar.Text = fila.Cells["marcas"].Value?.ToString();
                lblIdMarca.Text = fila.Cells["idMarcas"].Value?.ToString();
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
