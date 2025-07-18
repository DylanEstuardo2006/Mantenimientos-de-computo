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
        private bool isFormOpen = false;
        private SpeechRecognitionEngine recognizer; // <--- Creamos el objeto reconocimiento de voz para que reconozca los comandos
        SpeechSynthesizer synthesizer = new SpeechSynthesizer(); // <---- Creamos el bjeto sintetizador de voz para que nos hable
        public MenuPrincipal()
        {

            InitializeComponent();
           

        }


       

     
      
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // <--- Con este metodo le quitamos al usuario la capacidad de mover conn el cursor el form 
            this.MaximizeBox = false; // <--- Quitamos la capacidad de hacerlo a tamaño completo la pantalla el form 
                                      
            recognizer.RecognizeAsync(RecognizeMode.Multiple); // 🔹 aquí sí
        }

        private void btnDispositivos_Click(object sender, EventArgs e)
        {
            if (!PalDespegableDispositivos.Visible)
            {
                PalDespegableDispositivos.Visible = true;
            }
            else
            {
                PalDespegableDispositivos.Visible = false;
            }
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {

        }

        private void btnTecnicos_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTecnicos principal = new frmTecnicos();
            principal.Show();
        }

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTecnicos principal = new frmTecnicos();
            principal.Show();
        }

        private void btnDiagnostico_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDiagnosticos principal = new frmDiagnosticos();
            principal.Show();
        }

        private void PbxSonido_MouseEnter(object sender, EventArgs e)
        {
            synthesizer.SpeakAsyncCancelAll(); // Cancela cualquier voz en curso
            synthesizer.SpeakAsync("Haz click para activar botón de reconocimiento de voz");
        }

        private void PbxSonido_Click(object sender, EventArgs e)
        {
            recognizer.RecognizeAsync(RecognizeMode.Multiple);
            synthesizer.SpeakAsyncCancelAll(); // Cancela cualquier voz en curso
            synthesizer.SpeakAsync("Reconocimiento de voz activado Di abrir formulario con el nombre del formulario");
        }

        private void btnEjemplar_Click(object sender, EventArgs e)
        {

        }

        private void btnTipoDispositivo_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTipoDispositivo principal = new frmTipoDispositivo();
            principal.Show();
        }
    }
}
