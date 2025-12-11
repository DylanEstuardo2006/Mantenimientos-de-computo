using MySql.Data.MySqlClient;
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
    public partial class frmDispositivos : Form
    {
      //   private clsConexion conexion; // <--- Creamos un objeto de la clase clsConexion para poder conectarnos a la base de datos
        public frmDispositivos()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuPrincipal principal = new MenuPrincipal();
            principal.Show();   
        }
         private void frmDispositivos_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // <--- Con este metodo le quitamos al usuario la capacidad de mover conn el cursor el form 
            this.MaximizeBox = false; // <--- Quitamos la capacidad de hacerlo a tamaño completo la pantalla el form 
            cargaDatos();   // <--- Cargamos los datos 
            dgvDispositivos.EnableHeadersVisualStyles = false; // Necesario para que se apliquen los estilos personalizados
            dgvDispositivos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(47, 65, 86);
            dgvDispositivos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void cargaDatos()
        {
            
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }


        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void DgvDispositivos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxRegistrarActualizarUsuario_Enter(object sender, EventArgs e)
        {

        }
    }
}
