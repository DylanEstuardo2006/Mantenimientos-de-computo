using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mantenimientos_de_computo
{
    public partial class frmTipoDispositivo : Form
    {

        Validaciones Objeto = new Validaciones();
        private clsConexion conexion; // <----- Creamos la conexión privada 
        SpeechSynthesizer sintetizador = new SpeechSynthesizer(); // <---- Creamos el bjeto sintetizador de voz para que nos hables
        public frmTipoDispositivo()
        {
            InitializeComponent();
            this.btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.FlatAppearance.BorderSize = 0;
        }
      

        private void frmTipoDispositivo_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // <--- Con este metodo le quitamos al usuario la capacidad de mover conn el cursor el form 
            this.MaximizeBox = false; // <--- Quitamos la capacidad de hacerlo a tamaño completo la pantalla el form 
            cargaDatos();   // <--- Cargamos los datos 
            this.dgvTipoDispositivo.EnableHeadersVisualStyles = false; // Necesario para que se apliquen los estilos personalizados
            this.dgvTipoDispositivo.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 136, 62);
            this.dgvTipoDispositivo.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.dgvTipoDispositivo.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold); // Fuente opcional
        }
        private void cargaDatos()
        {
            conexion = new clsConexion();

            MySqlConnection con = conexion.getConnection();

            if(con != null)
            {

                string consulta = "SELECT * FROM tipodispositivo";
                MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, con);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dgvTipoDispositivo.DataSource = dataTable;
                dgvTipoDispositivo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                MessageBox.Show("Error al conectar");
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string tipoDispositivo = txtTipoDispositivo.Text;

            if (!string.IsNullOrEmpty(tipoDispositivo))
            {
                conexion = new clsConexion();
                MySqlConnection conn = conexion.getConnection();
                string consulta = "INSERT INTO tipodispositivo (tipoDispositivo) VALUES (@tipoDispositivo)";

                MySqlCommand command = new MySqlCommand(consulta, conn); //<----Command 
                command.Parameters.AddWithValue("@tipoDispositivo", tipoDispositivo);

                int filasAfectadas = command.ExecuteNonQuery();
                conn.Close();
         
                if(filasAfectadas > 0)
                {
                    MessageBox.Show("Registro Exitoso");
                    cargaDatos();
                   
                }
                else
                {
                    MessageBox.Show("El registro ha sido erroneo");
                }
            }
            else
            {
                MessageBox.Show("Los datos ingresados son nullos");
            }
            txtTipoDispositivo.Clear();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int idTipoDispositivo;

            if (!int.TryParse(lblIdTipoDispositivo.Text, out idTipoDispositivo))
            {
                MessageBox.Show("Por favor seleccione un tipo de dispositivo válido.");
                return; // detiene el método y evita el error
            }
            else
            {

          
                string tipoDispositivo = txtTipoDispositivo.Text;

                conexion = new clsConexion();

                MySqlConnection con = conexion.getConnection();

                string consulta;
                MySqlCommand command;

                if (string.IsNullOrEmpty(tipoDispositivo))
                {
                    MessageBox.Show("Casillas sin llenar");
                }
                else
                {
                    consulta = "update tipodispositivo set tipoDispositivo = @tipoDispositivo WHERE idTipoDispositivo = @idTipoDispositivo";
                    command = new MySqlCommand(consulta, con);

                    command.Parameters.AddWithValue("@tipoDispositivo", tipoDispositivo);
                    command.Parameters.AddWithValue("@idTipoDispositivo", idTipoDispositivo);

                    int filasAfectadas = command.ExecuteNonQuery();
                    con.Close();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Registro editado existosamente...");
                        cargaDatos();

                        txtTipoDispositivo.Text = "";
                        lblIdTipoDispositivo.Text = "";
                        txtEliminar.Text = "";
                        txtBuscar.Text = "";
                       
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar...");
                    }
                }
            }
             
        }

        private void button1_Click(object sender, EventArgs e) // Botón Eliminar
        {

            int idTipoDispositivo;

            if (!int.TryParse(lblIdTipoDispositivo.Text, out idTipoDispositivo))
            {
                MessageBox.Show("Por favor seleccione un tipo de dispositivo válido.");
                return; // detiene el método y evita el error
            }
            else
            {

                string tipoDispositivo = txtTipoDispositivo.Text;

                DialogResult result = MessageBox.Show("En verdad quieres eliminar el registro el tipo dispositivo " + tipoDispositivo + "?"
                 , "Eliminar", MessageBoxButtons.YesNo);


                if (result == DialogResult.No)
                {
                    return;
                }
                conexion = new clsConexion();
                MySqlConnection con = conexion.getConnection();

                string consulta;
                MySqlCommand command;
                consulta = "DELETE FROM tipodispositivo WHERE idTipoDispositivo = @idtipoDispositivo";
                command = new MySqlCommand(consulta, con);

                command.Parameters.AddWithValue("@idTipoDispositivo", idTipoDispositivo);

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
                
            }
            this.txtTipoDispositivo.Text = "";
            lblIdTipoDispositivo.Text = "";
            txtEliminar.Text = "";
            txtBuscar.Text = "";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuPrincipal principal = new MenuPrincipal();
            principal.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e) //Busqueda
        {

            string filtro = this.txtBuscar.Text;
            conexion = new clsConexion();
            MySqlConnection conn = conexion.getConnection();

            string consulta = "SELECT tipodispositivo.idTipoDispositivo,tipodispositivo.tipoDispositivo FROM tipodispositivo WHERE tipoDispositivo LIKE @busqueda";

            MySqlCommand command = new MySqlCommand(consulta, conn);
            command.Parameters.AddWithValue("@busqueda", "%" + filtro + "%");

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
           
            adapter.Fill(table);
            dgvTipoDispositivo.DataSource = table;
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvTipoDispositivo.Rows[e.RowIndex];
                txtTipoDispositivo.Text = fila.Cells["tipoDispositivo"].Value?.ToString();
                lblIdTipoDispositivo.Text = fila.Cells["idTipoDispositivo"].Value?.ToString();
                txtEliminar.Text = fila.Cells["tipoDispositivo"].Value?.ToString();
            }
        }
    }
}
