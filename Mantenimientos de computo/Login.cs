using BCrypt;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Mantenimientos_de_computo
{
    public partial class Login : Form
    {
        private clsConexion conexion;
      
        public Login()
        {
            InitializeComponent();
          
        }

        private void Login_Load(object sender, EventArgs e)
        {

            this.FormBorderStyle = FormBorderStyle.FixedSingle; // <--- Con este metodo le quitamos al usuario la capacidad de mover conn el cursor el form 
            this.MaximizeBox = false; // <--- Quitamos la capacidad de hacerlo a tamaño completo la pantalla el form 
            cargaDatos();
        }
        private void cargaDatos()
        {
            conexion = new clsConexion();//<-------- Mandar a llamar la clsConexión
            MySqlConnection con = conexion.getConnection();

            if (con != null)
            {
                string roles = "SELECT roles.idRoles,roles.roles FROM roles";
                MySqlDataAdapter cmb = new MySqlDataAdapter(roles, con);

                DataTable cmbRolesDato = new DataTable();
                cmb.Fill(cmbRolesDato);

                cmbRoles.DataSource = cmbRolesDato;
                cmbRoles.DisplayMember = "roles";
                cmbRoles.ValueMember = "idRoles";
                cmbRoles.SelectedIndex = -1;
            }
        }

        // Tengo inicializado el boton como false al momento de cargar el load (En las propiedades)

        private void btnMouseEnter(object sender, EventArgs e)
        {
            txtContrasenia.UseSystemPasswordChar = false;

        }
        private void btnMouseLeave(object sender, EventArgs e)
        {

            txtContrasenia.UseSystemPasswordChar = true;

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string matricula = txtUsuario.Text;
            string contrasenia = txtContrasenia.Text;
            int rolUsuario = Convert.ToInt32(cmbRoles.SelectedValue);

            if (string.IsNullOrWhiteSpace(matricula) || string.IsNullOrWhiteSpace(contrasenia))
            {
                MessageBox.Show("Faltan casillas por llenar ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if(cmbRoles.SelectedIndex == -1)
            {
                MessageBox.Show("No se ha seleccionado una sesión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                conexion = new clsConexion();
                MySqlConnection con = conexion.getConnection();

                string consulta = "select * from usuarios where matricula = @matricula AND contrasenia = @contrasenia AND idRoles = @idRoles";
                MySqlCommand command = new MySqlCommand(consulta, con);
                command.Parameters.AddWithValue("@matricula", matricula);
                command.Parameters.AddWithValue("@contrasenia", contrasenia);
                command.Parameters.AddWithValue("@idRoles", rolUsuario);

                MySqlDataReader reader = command.ExecuteReader();


                if (reader.Read())
                {

                    MessageBox.Show("Acceso correcto");
                    con.Close();
                    this.Hide();
                    MenuPrincipal principal = new MenuPrincipal();
                    principal.Show();


                }
                else
                {
                    con.Close();
                    MessageBox.Show("El password es incorrecto o el usuario no existe");

                }
            }   
        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {
            int radio = 20;
            Panel panel = (Panel)sender;

            // Crea un GraphicsPath con esquinas redondeadas
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radio, radio, 180, 90); // Esquina superior izquierda
            path.AddArc(panel.Width - radio, 0, radio, radio, 270, 90); // Esquina superior derecha
            path.AddArc(panel.Width - radio, panel.Height - radio, radio, radio, 0, 90); // Esquina inferior derecha
            path.AddArc(0, panel.Height - radio, radio, radio, 90, 90); // Esquina inferior izquierda
            path.CloseAllFigures();

            // Aplica la ruta como la región del panel
            panel.Region = new Region(path);

            // Opcional: Dibuja el borde si lo deseas
            using (Pen pen = new Pen(Color.Black, 2)) // Cambia Color.Black y 2 a tu gusto
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void PtbUsuario_Click(object sender, EventArgs e)
        {

        }
    }   
 }
          
 


   



