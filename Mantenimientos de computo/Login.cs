using BCrypt;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        clsConexion conexion;
     
        
        public Login()
        {
            InitializeComponent();
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // <--- Con este metodo le quitamos al usuario la capacidad de mover conn el cursor el form 
            this.MaximizeBox = false; // <--- Quitamos la capacidad de hacerlo a tamaño completo la pantalla el form 
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
            string email = txtUsuario.Text;
            string pass = txtContrasenia.Text;
           

            conexion = new clsConexion();
            MySqlConnection con = conexion.getConnection();

            string consulta = "select * from tecnicos where Email=@Email";
            MySqlCommand command = new MySqlCommand(consulta, con);
            command.Parameters.AddWithValue("@Email", email);
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                string passHash = reader["Contrasenia"]?.ToString();
                string Estado = reader["Estado"]?.ToString();
                //verificamos que el password coincida

                bool verifica = BCrypt.Net.BCrypt.Verify(pass, passHash);
                // nombre = reader["Nombre_tecnico"].ToString() + " " + reader["Apellido_paterno"].ToString() + " " + reader["Apellido_materno"].ToString();

                if (verifica == true && Estado == "1" )
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
           

    }

                  
 }


   



