using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Speech.Synthesis; // <--- Importamos la librería de síntesis de voz

namespace Mantenimientos_de_computo
{
    public partial class frmTecnicos : Form

    {

        Validaciones Objeto = new Validaciones();
        private clsConexion conexion; // <----- Creamos la conexión privada 
        SpeechSynthesizer sintetizador = new SpeechSynthesizer(); // <---- Creamos el bjeto sintetizador de voz para que nos hables
        public frmTecnicos()
        {
            InitializeComponent();
            TlpEliminar.SetToolTip(btnEliminar,"Este boton elimina el modelo y marca selecionados");
            TlpVolver.SetToolTip(btnVolver, "Este boton permite regresar al menu");
            TlpRegistrar.SetToolTip(btnRegistrar, "Este boton permite registrar nuevos técnicos");
            TlpTxtNombreTecnico.SetToolTip(txtNombreTecnico, "En esta caja de texto se ingresa los nombre de los nuevos tecnicos ");
            TlpBuscar.SetToolTip(txtBusqueda, "Escribe en la caja de texto y mostrara los datos que coincidan");
            TlpApellidoPaterno.SetToolTip(txtApellidoPaterno, "En esta caja de texto se ingresa el apellido paterno del tecnico");
            TlpApellidoMaterno.SetToolTip(txtApellidoMaterno, "En esta caja de texto se ingresa el apellido materno del tecnico");
            TlpTelefono.SetToolTip(txtNumeroTelefono, "En esta caja de texto se ingresa el numero de telefono del tecnico");
            TlpEmail.SetToolTip(txtEmail, "En esta caja de texto se ingresa el email del tecnico");
            TlpContrasenia.SetToolTip(txtContrasenia, "En esta caja de texto se ingresa la contraseña del tecnico, maximo 10 caracteres");
        }

        private void frmTecnicos_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // <--- Con este metodo le quitamos al usuario la capacidad de mover conn el cursor el form 
            this.MaximizeBox = false; // <--- Quitamos la capacidad de hacerlo a tamaño completo la pantalla el form 
            cargaDatos();   // <--- Cargamos los datos 
            DgvTecnicos.EnableHeadersVisualStyles = false; // Necesario para que se apliquen los estilos personalizados
            DgvTecnicos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(47,65,86);
            DgvTecnicos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DgvTecnicos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold); // Fuente opcional
        }
        private void btnVolver_Click(object sender, EventArgs e) //
        {
            this.Hide();
            MenuPrincipal principal = new MenuPrincipal();
            principal.Show();
        }
        private void cargaDatos()
        {
            conexion = new clsConexion(); //<--- Mandar a llamar la clsConexion 

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
        // Audios activos o desactivados
        private void btnRegistrar_MouseEnter(object sender, EventArgs e)
        {
            if (Audios.Accesibilidad)
            {
                sintetizador.SpeakAsyncCancelAll(); // Cancela cualquier voz en curso
                sintetizador.SpeakAsync("Esta sobre el boton de registrar, que permite registrar nuevos tecnicos");
            }
        
        }
        private void btnEliminar_MouseEnter(object sender, EventArgs e)
        {

            if (Audios.Accesibilidad)
            {
                sintetizador.SpeakAsyncCancelAll(); // Cancela cualquier voz en curso
                sintetizador.SpeakAsync("Esta sobre el botón Eliminar");
            }
        }
        private void btnActualizar_MouseEnter(object sender, EventArgs e)
        {
            if (Audios.Accesibilidad)
            {
                sintetizador.SpeakAsyncCancelAll(); // Cancela cualquier voz en curso
                sintetizador.SpeakAsync("Esta sobre el botón Actualizar, que permite actualizar un registro nuevo");
            }
        }
        private void btnVolver_MouseEnter(object sender, EventArgs e)
        {
            if (Audios.Accesibilidad)
            {
                sintetizador.SpeakAsyncCancelAll(); // Cancela cualquier voz en curso
                sintetizador.SpeakAsync("Esta sobre el botón Volver, permite actualizar volver al menú principal");
            }
        }


        // Registro de usuarios 


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            
            //En este apartado obtenemos los datos de las cajas de texto 
            string Nombre = txtNombreTecnico.Text;
            string ApellidoPaterno = txtApellidoPaterno.Text;
            string ApellidoMaterno = txtApellidoMaterno.Text;
            string NumeroTelefono = txtNumeroTelefono.Text;
            string Email = txtEmail.Text;
            string pass = txtContrasenia.Text;
            string Estado = "1"; // <----- Constante que permite Poner el estado de el usuario como activo o negativo 

            //En este if validamos con el IsNullOrEmpty para evitar que si el usuario no ingresa algun campo le salga un mensaje de faltan casillas por llenar 
            if (string.IsNullOrEmpty(Nombre) || string.IsNullOrEmpty(ApellidoPaterno) || string.IsNullOrEmpty(ApellidoMaterno) || string.IsNullOrEmpty(NumeroTelefono) || string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(pass))
            {
                if (Audios.Accesibilidad)
                {
                    sintetizador.SpeakAsyncCancelAll(); // Cancela cualquier voz en curso
                    sintetizador.SpeakAsync("Faltan casillas por llenar");
                }
                MessageBox.Show("Faltan casillas por llenar");

            }
            else
            {
                conexion = new clsConexion();
                MySqlConnection conn = conexion.getConnection();

                string consultaVerificar = "SELECT COUNT(*) FROM tecnicos WHERE Email = @Email OR Telefono = @Telefono";
                MySqlCommand verificar = new MySqlCommand(consultaVerificar,conn);

                verificar.Parameters.AddWithValue("@Email", Email);
                verificar.Parameters.AddWithValue("@Telefono", NumeroTelefono);

                int Existe = Convert.ToInt32(verificar.ExecuteScalar());
                if(Existe > 0)
                {
                    MessageBox.Show("El correo o el teléfono ya han sido registrados. Porfavor ingrese otros");
                    conn.Close();
                    return;
                }
                // Segunda validación para no permitir que el usuario haga una contraseña mayor de 10 caracteres
                if (pass.Length < 11)
                { 
                    pass = BCrypt.Net.BCrypt.HashPassword(pass); //<--- Encrypta las contraseñas 

                   //<--- Obtiene el metodo Conexion 

                    //Insertar los valores 
                    string consulta = "INSERT INTO tecnicos (Nombre_tecnico,Apellido_paterno,Apellido_materno,Telefono,Email,Contrasenia,Estado)" +
                      "VALUES (@Nombre_tecnico,@Apellido_paterno,@Apellido_materno,@Telefono,@Email,@Contrasenia,@Estado)";

                    MySqlCommand command = new MySqlCommand(consulta, conn); //<----Command 
                    command.Parameters.AddWithValue("@Nombre_tecnico", Nombre);
                    command.Parameters.AddWithValue("@Apellido_paterno", ApellidoPaterno);
                    command.Parameters.AddWithValue("@Apellido_materno", ApellidoMaterno);
                    command.Parameters.AddWithValue("@Telefono", NumeroTelefono);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@Contrasenia", pass);
                    command.Parameters.AddWithValue("@Estado", Estado); // <--- Estado por defecto al registrar un técnico
                    int filasAfectadas = command.ExecuteNonQuery();
                    conn.Close();

                    if (filasAfectadas > 0) //<---- Verificación que se haya echo correctamente
                    {
                        if (Audios.Accesibilidad)
                        {
                            sintetizador.SpeakAsyncCancelAll(); // Cancela cualquier voz en curso
                            sintetizador.SpeakAsync("Usted ha registrado un nuevo tecnico");
                        }
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
            // En este apartado las cajas se limpian inmediatamente de haber echo la operación 
            txtNombreTecnico.Text = "";
            txtApellidoPaterno.Text = "";
            txtApellidoMaterno.Text = "";
            txtContrasenia.Text = "";
            txtNumeroTelefono.Text = "";
            txtEmail.Text = "";
            txtContrasenia.Text = "";
        }
        // Botón de actualizar los datos de los técnicos 
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrWhiteSpace(lblIDTecnico.Text))
                {
                    MessageBox.Show("Porfavor seleccione un tecnico de la tabla para actualizar sus datos");
                    return; // <--- Si no hay un tecnico seleccionado, se sale del metodo
                }
                //En este apartado obtenemos los datos de las cajas de texto 
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

                    string consultaVerificar = "SELECT COUNT(*) FROM tenicos WHERE Email = @Email OR Telefono = @Telefono";
                    MySqlCommand verificar = new MySqlCommand(consultaVerificar, con);

                    verificar.Parameters.AddWithValue("@Email", Email);
                    verificar.Parameters.AddWithValue("@Telefono", NumeroTelefono);

                    int Existe = Convert.ToInt32(verificar.ExecuteScalar());
                    if (Existe > 0)
                    {
                        MessageBox.Show("El correo o el teléfono ya han sido registrados. Porfavor ingrese otros");
                        con.Close();
                        return;
                    }
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
            catch
            {
                
                MessageBox.Show("Error al actualizar, porfavor seleccione alguno de los datos que aparecen en la tabla");
            }

            // En este apartado las cajas se limpian inmediatamente de haber echo la operación 
            txtNombreTecnico.Text = "";
            txtApellidoPaterno.Text = "";
            txtApellidoMaterno.Text = "";
            txtContrasenia.Text = "";
            txtNumeroTelefono.Text = "";
            txtEmail.Text = "";
            txtContrasenia.Text = "";
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

                // Consulta y busca los tecnicos mediante su nombre, apellidos o Telefono (Falta activarlo mediante Email)
                string consulta = "SELECT tecnicos.Id_tecnico,tecnicos.Nombre_tecnico,tecnicos.Apellido_paterno,tecnicos.Apellido_materno,tecnicos.Telefono,tecnicos.Email,tecnicos.Contrasenia,tecnicos.Estado FROM tecnicos WHERE (tecnicos.Nombre_tecnico LIKE @busqueda OR tecnicos.Apellido_paterno LIKE @busqueda OR tecnicos.Apellido_materno LIKE @busqueda OR tecnicos.Telefono LIKE @busqueda) AND tecnicos.Estado = 1";


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
            try
            {
                if (string.IsNullOrWhiteSpace(lblIDTecnico.Text))
            {
                MessageBox.Show("Porfavor seleccione un tecnico de la tabla para Eliminar sus datos");
                return; // <--- Si no hay un tecnico seleccionado, se sale del metodo
            }
            string Estado = "0"; //<----- Constante que permite cambiar el estado del usuario y hacerlo accesible o no 
            string NombreTecnico = txtNombreTecnico.Text + " " + txtApellidoPaterno.Text + " " + txtApellidoMaterno.Text; // <--- Concatenamos el nombre del tecnico para mostrarlo en el mensaje de confirmación
                int IdTecnico = Convert.ToInt32(lblIDTecnico.Text);
          
            DialogResult result = MessageBox.Show("En verdad quieres eliminar el registro de : " + NombreTecnico + "?"
                    , "Eliminar", MessageBoxButtons.YesNo);

                if (result == DialogResult.No)
                {
                    return;
                }
                conexion = new clsConexion();
                MySqlConnection con = conexion.getConnection();

          
                string consulta;
                MySqlCommand command;
                consulta = "update tecnicos set Estado=@Estado where Id_tecnico=@Id_tecnico"; //<----- En este apartado hacemos una eliminación logica y no Física, evitamos un mensaje de error 
                command = new MySqlCommand(consulta, con);

                command.Parameters.AddWithValue("@Estado", Estado);
                command.Parameters.AddWithValue("@Id_tecnico", IdTecnico);

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
                txtNombreTecnico.Text = "";
                txtApellidoPaterno.Text = "";
                txtApellidoMaterno.Text = "";
                txtContrasenia.Text = "";
                txtNumeroTelefono.Text = "";
                txtEmail.Text = "";
                txtContrasenia.Text = "";
            }
            catch
            {
                     MessageBox.Show("Error al eliminar, porfavor seleccione alguno de los datos que aparecen en la tabla");
            }
          
        }

        
    }
}
