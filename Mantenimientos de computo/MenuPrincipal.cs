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
        private SpeechRecognitionEngine recognizer; // <--- Creamos el objeto reconocimiento de voz para que reconozca los comandos
        SpeechSynthesizer synthesizer = new SpeechSynthesizer(); // <---- Creamos el bjeto sintetizador de voz para que nos hable
        public MenuPrincipal()
        {

            InitializeComponent();
            InitializeSpeechRecognition(); // <--- Inicializamos el reconocimiento de voz 

        }

        private void InitializeSpeechRecognition()
        {
           recognizer = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("es-Mx"));

            // Comandos permitidos
            Choices comandos = new Choices(); // <--- Creamos los comandos que el usuario puede decir
            comandos.Add(new string[] { "abrir formulario tecnicos","abrir formulario diagnosticos", "cerrar aplicación" }); // <--- Añadimos los comandos que el usuario puede decir

            GrammarBuilder gb = new GrammarBuilder(); // <--- Creamos un objeto de tipo GrammarBuilder para construir la gramática 

            gb.Append(comandos); // <--- Añadimos los comandos al objeto GrammarBuilder (Ejecución)

            Grammar grammar = new Grammar(gb);
            recognizer.LoadGrammar(grammar);

            recognizer.SetInputToDefaultAudioDevice();
            recognizer.SpeechRecognized += Recognizer_SpeechRecognized;
        }


        private void Recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            switch (e.Result.Text)
            {
                case "abrir formulario tecnicos":
                    frmTecnicos principal  = new frmTecnicos();
                    principal.Show();
                    break;
                case "abrir formulario diagnosticos":
                    frmDiagnosticos detalles = new frmDiagnosticos();
                    detalles.Show();
                    break;
                case "cerrar aplicación":
                    Application.Exit();
                    break;
            }
        }
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // <--- Con este metodo le quitamos al usuario la capacidad de mover conn el cursor el form 
            this.MaximizeBox = false; // <--- Quitamos la capacidad de hacerlo a tamaño completo la pantalla el form 
           // this.Text = "Bienvenido " + Nombre_usuario;
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

    }
}
