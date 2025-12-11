using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition; // <--- Importamos la librería de reconocimiento de voz
using System.Speech.Synthesis; // <--- Importamos la librería de síntesis de voz


namespace Mantenimientos_de_computo
{
    public partial class MenuPrincipal : Form
    {
      

        Validaciones audio  = new Validaciones(); // <--- Creamos un objeto de la clase Validaciones para usar sus metodos de validaciones
        SpeechSynthesizer sintetizador = new SpeechSynthesizer(); // <---- Creamos el bjeto sintetizador de voz para que nos hable
      
        public MenuPrincipal()
        {

            InitializeComponent();
           

        }
   
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // <--- Con este metodo le quitamos al usuario la capacidad de mover conn el cursor el form 
            this.MaximizeBox = false; // <--- Quitamos la capacidad de hacerlo a tamaño completo la pantalla el form 
           
        }
        //Botón que al darle un click te muestra los apartados sobre los dispositivos
        private void btnDispositivos_Click(object sender, EventArgs e)
        { 

        }
        //Botón Que cuando entra al apartado dispositivos si el audio esta activado lo muestre
        private void btnDispositivos_MouseEnter(object sender, EventArgs e)
        {
            if (Audios.Accesibilidad)
            {
                sintetizador.SpeakAsyncCancelAll(); // Cancela cualquier voz en curso
                sintetizador.SpeakAsync("Esta sobre el Despegable Detalles que muestra el despegable con los formularios de los dispositivos");
            }
        }

        private void btnTecnicos_MouseEnter(object sender, EventArgs e)
        {
            if(Audios.Accesibilidad)
            {
                sintetizador.SpeakAsyncCancelAll(); // Cancela cualquier voz en curso
                sintetizador.SpeakAsync("Esta sobre el botón tecnicos");
            }
        }
        private void btnTipoDispositivo_MouseEnter(object sender, EventArgs e)
        {
            if (Audios.Accesibilidad)
            {
                sintetizador.SpeakAsyncCancelAll(); // Cancela cualquier voz en curso
                sintetizador.SpeakAsync("Esta sobre el botón Tipo Dispositivo");
            }
        }

        private void btnMarca_MouseEnter(object sender, EventArgs e)
        {
            if (Audios.Accesibilidad)
            {
                sintetizador.SpeakAsyncCancelAll(); // Cancela cualquier voz en curso
                sintetizador.SpeakAsync("Esta sobre el botón de Marcas");
            }
        }
        private void btnMantenimiento_MouseEnter(object sender, EventArgs e)
        {
            if (Audios.Accesibilidad)
            {
                sintetizador.SpeakAsyncCancelAll(); // Cancela cualquier voz en curso
                sintetizador.SpeakAsync("Esta sobre el botón Mantenimiento");
            }
        }
        private void btnLaboratorio_MouseEnter(object sender, EventArgs e)
        {
            if (Audios.Accesibilidad)
            {
                sintetizador.SpeakAsyncCancelAll(); // Cancela cualquier voz en curso
                sintetizador.SpeakAsync("Esta sobre el botón de Laboratorio");
            }
        }

     
        private void btnModelo_MouseEnter(object sender, EventArgs e)
        {
            if (Audios.Accesibilidad)
            {
                sintetizador.SpeakAsyncCancelAll(); // Cancela cualquier voz en curso
                sintetizador.SpeakAsync("Esta sobre el botón Modelo");
            }
        }
        private void btnDetalles_MouseEnter(object sender, EventArgs e)
        {
            if (Audios.Accesibilidad)
            {
                sintetizador.SpeakAsyncCancelAll(); // Cancela cualquier voz en curso
                sintetizador.SpeakAsync("Esta sobre el botón Dispositivos");
            }
        }
   



        private void btnTecnicos_Click(object sender, EventArgs e)
        {
            this.Close();
            frmUsuario principal = new frmUsuario();
            principal.Show();
        }
      
        private void btnMarca_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMarcas principal = new frmMarcas();
            principal.Show(); // <--- Cierra el formulario MenuPrincipal y abre el formulario frmMarcas
        }
        // BtnTecncios click, oculta el formulario de MenuPrincipal y muestra el de Tecnicos
        private void btnTipoDispositivo_Click(object sender, EventArgs e)
        {
            this.Close();
            frmTipoDispositivo principal = new frmTipoDispositivo();
            principal.Show();
        }
        private void btnModelo_Click(object sender, EventArgs e)
        {
            this.Close();
            frmModelos principal = new frmModelos();
            principal.Show(); // <--- Cierra el formulario MenuPrincipal y abre el formulario frmModelos
        }
        private void btnLaboratorio_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLaboratorios principal = new frmLaboratorios();
            principal.Show();
        }
        private void btnDetalles_Click(object sender, EventArgs e)
        {
            this.Close(); // <--- Cierra el formulario MenuPrincipal
            frmDispositivos principal = new frmDispositivos(); // <--- Creamos una instancia del form frmTipoDispositivo  
            principal.Show();
        }

      

        private void PbxSonido_MouseEnter(object sender, EventArgs e)
        {
            sintetizador.SpeakAsyncCancelAll(); // Cancela cualquier voz en curso
            if(Audios.Accesibilidad == true)
            {
                sintetizador.SpeakAsync("Usted tiene activado los botones con audio"); 

            }
            else if (Audios.Accesibilidad == false)
            {
                sintetizador.SpeakAsync("Haz click para activar los botones con audio");
            }

               
        }

        private void PbxSonido_Click(object sender, EventArgs e)
        {
            Audios.Accesibilidad = !Audios.Accesibilidad; // <--- Llamamos al metodo Audio de la clase Audios para activar los botones con audio
            sintetizador.SpeakAsyncCancelAll(); // Cancela cualquier voz en curso
           
            if(Audios.Accesibilidad)
            {
                sintetizador.SpeakAsync("Usted ha activado los botones con audio");
                
            }
            else
            {
                sintetizador.SpeakAsync("Usted ha desactivado los botones con audio");
            }
             
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
          Application.Exit(); // <--- Cierra el formulario MenuPrincipal
        }

      
    }
}
