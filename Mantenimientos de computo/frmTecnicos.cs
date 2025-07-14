using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Mantenimientos_de_computo
{
    public partial class frmTecnicos : Form

    {
        Validaciones Objeto = new Validaciones();
        private clsConexion conexion; // <----- Creamos la conexión privada 
        public frmTecnicos()
        {
            InitializeComponent();
        }

        private void frmTecnicos_Load(object sender, EventArgs e)
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

                string consulta = "SELECT tecnicos.Id_tecnico,tecnicos.Nombre_tecnico,tecnicos.Apellido_paterno,tecnicos.Apellido_materno,tecnicos.Telefono,tecnicos.Email,tecnicos.Contrasenia,tecnicos.Estado FROM tecnicos where Estado = 1";

                //Creamos un adaptador 

                MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, con);

                //Creamos una datable 

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                //Asignamos el datatable al souce del datagrid 

                DgvTecnicos.DataSource = dataTable;

                DgvTecnicos.Columns["Id_tecnico"].Visible = false;
                DgvTecnicos.Columns["Estado"].Visible = false; // <--- Ocultamos la columna de Estado por seguridad   
                DgvTecnicos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                MessageBox.Show("Error al conectar");
            }
        }

        private void DgvTecnicos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
        }
        // Validación de las cajas de texto para evitar datos no correctos 

        //Validación de la caja de texto Nombre Técnico 
        private void txtNombreTecnico_KeyPress(object sender, KeyPressEventArgs e)
        {

            Objeto.ValidarLetras(e);

        }
        //Validación de la caja de texto Apellido Paterno del Técnico 
        private void txtApellidoPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            Objeto.ValidarLetras(e);
        }
        //Validación de la caja de texto Apellido Materno del Técnico 
        private void txtApellidoMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            Objeto.ValidarLetras(e);
        }
        // Validación del campo Número de Teléfono 
        private void txtNumeroTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Objeto.ValidarNumeros(e);
        }
        //Validación del campo Email
        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            Objeto.ValidarSeparadores(e);
        }
        private void txtContrasenia_KeyPress(object sender, KeyPressEventArgs e)
        {
            Objeto.ValidarSeparadores(e);
        }
        // Registro de usuarios 

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string Nombre = txtNombreTecnico.Text;
            string ApellidoPaterno = txtApellidoPaterno.Text;
            string ApellidoMaterno = txtApellidoMaterno.Text;
            string NumeroTelefono = txtNumeroTelefono.Text;
            string Email = txtEmail.Text;
            string pass = txtContrasenia.Text;

            if (string.IsNullOrEmpty(Nombre) || string.IsNullOrEmpty(ApellidoPaterno) || string.IsNullOrEmpty(ApellidoMaterno) || string.IsNullOrEmpty(NumeroTelefono) || string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Faltan casillas por llenar");

            }
            else
            {
                if (pass.Length < 11)
                {
                    pass = BCrypt.Net.BCrypt.HashPassword(pass);

                    conexion = new clsConexion();
                    MySqlConnection conn = conexion.getConnection();

                    string consulta = "INSERT INTO tecnicos (Nombre_tecnico,Apellido_paterno,Apellido_materno,Telefono,Email,Contrasenia,Estado)" +
                      "VALUES (@Nombre_tecnico,@Apellido_paterno,@Apellido_materno,@Telefono,@Email,@Contrasenia,@Estado)";

                    MySqlCommand command = new MySqlCommand(consulta, conn);
                    command.Parameters.AddWithValue("@Nombre_tecnico", Nombre);
                    command.Parameters.AddWithValue("@Apellido_paterno", ApellidoPaterno);
                    command.Parameters.AddWithValue("@Apellido_materno", ApellidoMaterno);
                    command.Parameters.AddWithValue("@Telefono", NumeroTelefono);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@Contrasenia", pass);
                    command.Parameters.AddWithValue("@Estado", "0"); // <--- Estado por defecto al registrar un técnico
                    int filasAfectadas = command.ExecuteNonQuery();
                    conn.Close();

                    if (filasAfectadas > -1)
                    {
                        MessageBox.Show("Registro extitoso...");
                        cargaDatos();
                    }
                    else
                    {
                        MessageBox.Show("Algo anda mal...");
                    }
                }
                else
                {
                    MessageBox.Show("Solo se permite maximo 10 digitos");
                }
            }
        }
        // Botón de actualizar los datos de los técnicos 
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int IdTecnico = Convert.ToInt32(lblIDTecnico.Text);
            string Nombre = txtNombreTecnico.Text;
            string ApellidoPaterno = txtApellidoPaterno.Text;
            string ApellidoMaterno = txtApellidoMaterno.Text;
            string NumeroTelefono = txtNumeroTelefono.Text;
            string Email = txtEmail.Text;
            string pass = txtContrasenia.Text;


            conexion = new clsConexion();
            MySqlConnection con = conexion.getConnection();

            string consulta;
            MySqlCommand command;
            if (string.IsNullOrEmpty(Nombre) || string.IsNullOrEmpty(ApellidoPaterno) || string.IsNullOrEmpty(ApellidoMaterno) || string.IsNullOrEmpty(NumeroTelefono) || string.IsNullOrEmpty(Email))
            {
                MessageBox.Show("Faltan casillas por llenar");

            }
            else
            {
                if (!string.IsNullOrEmpty(pass))
                {
                    consulta = "Update tecnicos set Nombre_tecnico=@Nombre_tecnico, Contrasenia=@Contrasenia,Apellido_paterno=@Apellido_paterno,Apellido_materno=@Apellido_materno,Telefono=@Telefono,Email=@Email where Id_tecnico =@Id_tecnico";
                    command = new MySqlCommand(consulta, con);
                    command.Parameters.AddWithValue("@Contrasenia", pass);
                }
                else
                {
                    consulta = "Update tecnicos set Nombre_tecnico=@Nombre_tecnico,Apellido_paterno=@Apellido_paterno,Apellido_materno=@Apellido_materno,Telefono=@Telefono,Email= @Email where Id_tecnico=@Id_tecnico";
                    command = new MySqlCommand(consulta, con);
                }
                command.Parameters.AddWithValue("@Nombre_tecnico", Nombre);
                command.Parameters.AddWithValue("@Apellido_paterno", ApellidoPaterno);
                command.Parameters.AddWithValue("@Apellido_materno", ApellidoMaterno);
                command.Parameters.AddWithValue("@Email", Email);
                command.Parameters.AddWithValue("@Telefono", NumeroTelefono);
                command.Parameters.AddWithValue("@Id_tecnico", IdTecnico);
            



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

       
        
        //Llena los combobox 
        private void DgvTecnicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = DgvTecnicos.Rows[e.RowIndex];
                txtNombreTecnico.Text = fila.Cells["Nombre_tecnico"].Value?.ToString();
                txtApellidoPaterno.Text = fila.Cells["Apellido_paterno"].Value?.ToString();
                txtApellidoMaterno.Text = fila.Cells["Apellido_materno"].Value?.ToString();
                txtNumeroTelefono.Text = fila.Cells["Telefono"].Value?.ToString();
                txtEmail.Text = fila.Cells["Email"].Value?.ToString();
              
                lblIDTecnico.Text = fila.Cells["Id_tecnico"].Value.ToString();

            }
        }
        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBusqueda.Text;
            conexion = new clsConexion();

            MySqlConnection con = conexion.getConnection();
        
            string consulta = "SELECT tecnicos.Id_tecnico,tecnicos.Nombre_tecnico,tecnicos.Apellido_paterno,tecnicos.Apellido_materno,tecnicos.Telefono,tecnicos.Email,tecnicos.Contrasenia FROM tecnicos WHERE tecnicos.Nombre_tecnico LIKE @busqueda OR tecnicos.Apellido_paterno LIKE @busqueda OR tecnicos.Apellido_materno LIKE @busqueda OR tecnicos.Telefono LIKE @busqueda";
       
        
            MySqlCommand command = new MySqlCommand(consulta, con);
            command.Parameters.AddWithValue("@busqueda", "%" + filtro + "%");

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);
            DgvTecnicos.DataSource = table;
            DgvTecnicos.Columns["Id_tecnico"].Visible = false;
            con.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            conexion = new clsConexion();
            MySqlConnection con = conexion.getConnection();

            string consulta;
            MySqlCommand command;
            consulta = "UPDATE tecnicos SET Estado=@Estado WHERE Id_tecnico = @Id_tecnico";
            command = new MySqlCommand(consulta, con);

            command.Parameters.AddWithValue("@Estado","0"); // <--- Cambiamos el estado a 0 para eliminar el técnico

            int filasAfectadas = command.ExecuteNonQuery();

            con.Close();

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Registro editado existosamente...");
                cargaDatos();
            }
            else
            {
                MessageBox.Show("Error al Eliminar");
            }
        }
    }
}
