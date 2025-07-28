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
    public partial class frmMapaNavegacion : Form
    {
        public frmMapaNavegacion()
        {
            InitializeComponent();
        }

        private void btnDiagnostico_Click(object sender, EventArgs e)
        {
           this.Close();
           frmDiagnosticos principal = new frmDiagnosticos();
           principal.Show();
        }
        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMantenimiento principal = new frmMantenimiento();
            principal.Show();
        }
        private void btnMarca_Click(object sender, EventArgs e)
        {
           
        }

        private void btnTecnicos_Click(object sender, EventArgs e)
        {
            this.Close();
            frmTecnicos principal = new frmTecnicos();
            principal.Show(); // <--- Cierra el formulario MenuPrincipal y abre el formulario frmMarcas
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            this.Close();
            frmHistorial principal = new frmHistorial();
            principal.Show(); // <--- Cierra el formulario MenuPrincipal y abre el formulario frmMarcas
        }

        private void btnDispositivo_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDispositivos principal = new frmDispositivos();
            principal.Show(); // <--- Cierra el formulario MenuPrincipal y abre el formulario frmMarcas
        }

        private void btnLaboratorio_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLaboratorios principal = new frmLaboratorios();
            principal.Show(); // <--- Cierra el formulario MenuPrincipal y abre el formulario frmMarcas
        }

        private void btnModelos_Click(object sender, EventArgs e)
        {
            this.Close();
            frmModelos principal = new frmModelos();    

        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMarcas principal = new frmMarcas();
            principal.Show(); // <--- Cierra el formulario MenuPrincipal y abre el formulario frmMarcas
        }

        private void btnEjemplares_Click(object sender, EventArgs e)
        {
            this.Close();
            frmEjemplares principal = new frmEjemplares();  
            principal.Show(); // <--- Cierra el formulario MenuPrincipal y abre el formulario frmMarcas    
        }

        private void btnTipoDispositivo_Click(object sender, EventArgs e)
        {
            this.Close();
            frmTipoDispositivo principal = new frmTipoDispositivo();    
            principal.Show(); // <--- Cierra el formulario MenuPrincipal y abre el formulario frmMarcas
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuPrincipal principal = new MenuPrincipal();  
            principal.Show(); // <--- Cierra el formulario MenuPrincipal y abre el formulario frmMarcas
        }
    }
}
