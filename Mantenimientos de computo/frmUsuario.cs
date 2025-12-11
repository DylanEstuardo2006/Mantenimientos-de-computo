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
    public partial class frmUsuario : Form

    {

        Validaciones Objeto = new Validaciones();
        private clsConexion conexion; // <----- Creamos la conexión privada 
        SpeechSynthesizer sintetizador = new SpeechSynthesizer(); // <---- Creamos el bjeto sintetizador de voz para que nos hables
        public frmUsuario()
        {
            InitializeComponent();

            this.btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.FlatAppearance.BorderSize = 0;
            TlpRegistrar.SetToolTip(btnRegistrar, "Este boton permite registrar nuevos técnicos");
            TlpTxtNombreTecnico.SetToolTip(txtNombreUsuario, "En esta caja de texto se ingresa los nombre de los nuevos tecnicos ");
            TlpApellidoPaterno.SetToolTip(txtApellidoPaterno, "En esta caja de texto se ingresa el apellido paterno del tecnico");
            TlpApellidoMaterno.SetToolTip(txtApellidoMaterno, "En esta caja de texto se ingresa el apellido materno del tecnico");
            TlpTelefono.SetToolTip(txtNumeroTelefono, "En esta caja de texto se ingresa el numero de telefono del tecnico");
            TlpContrasenia.SetToolTip(txtContrasenia, "En esta caja de texto se ingresa la contraseña del tecnico, maximo 10 caracteres");
        }

        private void frmTecnicos_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // <--- Con este metodo le quitamos al usuario la capacidad de mover conn el cursor el form 
            this.MaximizeBox = false; // <--- Quitamos la capacidad de hacerlo a tamaño completo la pantalla el form 
            cargaDatos();   // <--- Cargamos los datos 
            this.dgvUsuarios.EnableHeadersVisualStyles = false; // Necesario para que se apliquen los estilos personalizados
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 136, 62);
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold); // Fuente opcional
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

                string consulta = "SELECT usuarios.idUsuario,usuarios.nombre,usuarios.apellidoPaterno,usuarios.apellidoMaterno, usuarios.matricula,usuarios.contrasenia,usuarios.telefono,roles.roles,roles.idRoles FROM usuarios,roles WHERE usuarios.idRoles = roles.idRoles";

                //Creamos un adaptador 

                MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, con);

                //Creamos una datable 

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);


                string roles = "SELECT roles.idRoles,roles.roles FROM roles";
                MySqlDataAdapter cmb = new MySqlDataAdapter(roles, con);

                DataTable cmbRolesDato = new DataTable();
                cmb.Fill(cmbRolesDato);
                //Asignamos el datatable al souce del datagrid 

                dgvUsuarios.DataSource = dataTable;
                dgvUsuarios.Columns["idUsuario"].Visible = false;
                dgvUsuarios.Columns["idRoles"].Visible = false;
                dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
             
                cmbRoles.DataSource = cmbRolesDato;
                cmbRoles.DisplayMember = "roles";
                cmbRoles.ValueMember = "idRoles";
                cmbRoles.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Error al conectar");
            }
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
        private void txtMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            Objeto.ValidarNumeros(e);
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
            string nombre = txtNombreUsuario.Text;
            string apellidoPaterno = txtApellidoPaterno.Text;
            string apellidoMaterno = txtApellidoMaterno.Text;
            string numeroTelefono = txtNumeroTelefono.Text;
            string matricula = txtMatricula.Text;
            string contrasenia = txtContrasenia.Text;
            int idRoles = Convert.ToInt32(cmbRoles.SelectedValue);

            //En este if validamos con el IsNullOrEmpty para evitar que si el usuario no ingresa algun campo le salga un mensaje de faltan casillas por llenar 
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellidoPaterno) || string.IsNullOrEmpty(apellidoMaterno) || string.IsNullOrEmpty(numeroTelefono) || string.IsNullOrEmpty(matricula) || string.IsNullOrEmpty(contrasenia) || this.cmbRoles.SelectedIndex == -1)
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

                string consultaVerificar = "SELECT COUNT(*) FROM usuarios WHERE matricula = @matricula ";
                MySqlCommand verificar = new MySqlCommand(consultaVerificar,conn);

                verificar.Parameters.AddWithValue("@matricula", matricula);

                int existe = Convert.ToInt32(verificar.ExecuteScalar());
                if(existe > 0)
                {
                    MessageBox.Show("La matricula ya ha sido registrada. Porfavor ingrese otra");
                    conn.Close();
                    return;
                }
                // Segunda validación para no permitir que el usuario haga una contraseña mayor de 10 caracteres
                if (contrasenia.Length <= 20)
                { 
                   
                    //Insertar los valores 
                    string consulta = "INSERT INTO usuarios (nombre,apellidoPaterno,apellidoMaterno,telefono,matricula,contrasenia,idRoles)" +
                      "VALUES (@nombre,@apellidoPaterno,@apellidoMaterno,@telefono,@matricula,@contrasenia,@idRoles)";

                    MySqlCommand command = new MySqlCommand(consulta, conn); //<----Command 
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellidoPaterno", apellidoPaterno);
                    command.Parameters.AddWithValue("@apellidoMaterno", apellidoMaterno);
                    command.Parameters.AddWithValue("@telefono", numeroTelefono);
                    command.Parameters.AddWithValue("@matricula", matricula);
                    command.Parameters.AddWithValue("@contrasenia", contrasenia);
                    command.Parameters.AddWithValue("@idRoles", idRoles);
                 
                    int filasAfectadas = command.ExecuteNonQuery();
                    conn.Close();

                    if (filasAfectadas > 0) //<---- Verificación que se haya echo correctamente
                    {
                        if (Audios.Accesibilidad)
                        {
                            sintetizador.SpeakAsyncCancelAll(); // Cancela cualquier voz en curso
                            sintetizador.SpeakAsync("Usted ha registrado un nuevo usuario");
                        }
                        MessageBox.Show("Registro extitoso..."); 
                        cargaDatos();
                    }
                    else
                    {
                        MessageBox.Show("Algo anda mal...");
                    }
                    // En este apartado las cajas se limpian inmediatamente de haber echo la operación 
                    txtNombreUsuario.Text = "";
                    txtApellidoPaterno.Text = "";
                    txtApellidoMaterno.Text = "";
                    txtContrasenia.Text = "";
                    txtNumeroTelefono.Text = "";
                    this.txtMatricula.Text = "";
                    this.cmbRoles.SelectedIndex = -1;
                    this.txtEliminar.Text = "";
                }
                else
                {
                    MessageBox.Show("Solo se permite maximo 20 digitos");
                }
            }
            
        }
        // Botón de actualizar los datos de los técnicos 
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int idUsuario;

            if (!int.TryParse(lblIdUsuario.Text, out idUsuario))
            {
                MessageBox.Show("Seleccione un usuario válido.");
                return;
            }

            //En este apartado obtenemos los datos de las cajas de texto 
           
            string Nombre = txtNombreUsuario.Text;
            string apellidoPaterno = txtApellidoPaterno.Text;
            string apellidoMaterno = txtApellidoMaterno.Text;
            string numeroTelefono = txtNumeroTelefono.Text;
            string contrasenia = txtContrasenia.Text;
            string matricula = txtMatricula.Text;
            int idRoles = Convert.ToInt32(cmbRoles.SelectedValue);


            conexion = new clsConexion();
            MySqlConnection con = conexion.getConnection();

            string consulta;
            MySqlCommand command;
            if (string.IsNullOrEmpty(Nombre) || string.IsNullOrEmpty(apellidoPaterno) || string.IsNullOrEmpty(apellidoMaterno) || string.IsNullOrEmpty(numeroTelefono) || string.IsNullOrEmpty(matricula) || string.IsNullOrEmpty(contrasenia) || cmbRoles.SelectedIndex == -1)
            {
                MessageBox.Show("Faltan casillas por llenar");
            }
            else
            {
                consulta = "Update usuarios set nombre=@nombre,apellidoPaterno=@apellidoPaterno,apellidoMaterno=@apellidoMaterno,telefono=@telefono,matricula = @matricula,contrasenia = @contrasenia,idRoles = @idRoles where idUsuario = @idUsuario";
                command = new MySqlCommand(consulta, con);

                command.Parameters.AddWithValue("@nombre", Nombre);
                command.Parameters.AddWithValue("@apellidoPaterno", apellidoPaterno);
                command.Parameters.AddWithValue("@apellidoMaterno", apellidoMaterno);
                command.Parameters.AddWithValue("@telefono", numeroTelefono);
                command.Parameters.AddWithValue("@matricula", matricula);
                command.Parameters.AddWithValue("@contrasenia", contrasenia);
                command.Parameters.AddWithValue("@idRoles", idRoles);
                command.Parameters.AddWithValue("@idUsuario", idUsuario);

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
            txtNombreUsuario.Text = "";
            txtApellidoPaterno.Text = "";
            txtApellidoMaterno.Text = "";
            txtContrasenia.Text = "";
            txtNumeroTelefono.Text = "";
            this.txtMatricula.Text = "";
            this.cmbRoles.SelectedIndex = -1;
            txtEliminar.Text = "";
            this.lblIdUsuario.Text = "";
    
            // En este apartado las cajas se limpian inmediatamente de haber echo la operación 

        }
          
        //Llena los combobox 
    
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int idUsuario = Convert.ToInt32(lblIdUsuario.Text);
                string matricula = txtMatricula.Text;

                DialogResult result = MessageBox.Show("En verdad quieres eliminar el registro del usuario con la matricula: " + matricula + "?"
                   , "Eliminar", MessageBoxButtons.YesNo);

                if (result == DialogResult.No)
                {
                    return;
                }
                conexion = new clsConexion();
                MySqlConnection con = conexion.getConnection();


                string consulta;
                MySqlCommand command;
                consulta = "DELETE FROM usuarios WHERE idUsuario = @idUsuario";
                command = new MySqlCommand(consulta, con);

                command.Parameters.AddWithValue("@idUsuario", idUsuario);

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
                txtNombreUsuario.Text = "";
                txtApellidoPaterno.Text = "";
                txtApellidoMaterno.Text = "";
                txtContrasenia.Text = "";
                txtNumeroTelefono.Text = "";
                this.txtMatricula.Text = "";
                this.cmbRoles.SelectedIndex = -1;
                this.txtEliminar.Text = "";
                this.lblIdUsuario.Text = "";
            }
            catch
            {
                MessageBox.Show("Error al eliminar, porfavor seleccione alguno de los datos que aparecen en la tabla");
            }

        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            this.Close();
            MenuPrincipal principal = new MenuPrincipal();
            principal.Show();
        }

        private void txtBusqueda_TextChanged_1(object sender, EventArgs e)
        {
            string filtro = txtBusqueda.Text;
            conexion = new clsConexion();
            MySqlConnection conn = conexion.getConnection();

            string consulta = "SELECT usuarios.idUsuario,usuarios.nombre,usuarios.apellidoPaterno,usuarios.apellidoMaterno, usuarios.matricula,usuarios.contrasenia,usuarios.telefono,roles.roles FROM usuarios INNER JOIN roles ON usuarios.idRoles = roles.idRoles WHERE matricula LIKE @busqueda";
      
             MySqlCommand command = new MySqlCommand(consulta, conn);
            command.Parameters.AddWithValue("@busqueda", "%" + filtro + "%");
             
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvUsuarios.DataSource = table;
            dgvUsuarios.Columns["idUsuario"].Visible = false;
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvUsuarios.Rows[e.RowIndex];
                txtNombreUsuario.Text = fila.Cells["nombre"].Value?.ToString();
                txtApellidoPaterno.Text = fila.Cells["apellidoPaterno"].Value?.ToString();
                txtApellidoMaterno.Text = fila.Cells["apellidoMaterno"].Value?.ToString();
                txtNumeroTelefono.Text = fila.Cells["telefono"].Value?.ToString();
                txtMatricula.Text = fila.Cells["matricula"].Value?.ToString();
                txtContrasenia.Text = fila.Cells["contrasenia"].Value?.ToString();
                txtEliminar.Text = fila.Cells["matricula"].Value?.ToString();
                cmbRoles.SelectedValue = fila.Cells["idRoles"].Value?.ToString();
                lblIdUsuario.Text = fila.Cells["idUsuario"].Value?.ToString();
            }
        }
    }
}
