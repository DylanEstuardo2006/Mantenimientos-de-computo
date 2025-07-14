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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {

            InitializeComponent();
          
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
            frmTecnicos principal = new frmTecnicos();
            principal.Show();
        }
    }
}
