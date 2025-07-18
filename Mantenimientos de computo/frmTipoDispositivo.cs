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
    public partial class frmTipoDispositivo : Form
    {
        private clsConexion conexion;
        public frmTipoDispositivo()
        {
            InitializeComponent();
        }

        private void frmTipoDispositivo_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            cargarDatos();
        }
        private void cargarDatos() 
        {
            conexion = new clsConexion();
            MySqlConnection con = conexion.getConnection();

            // Comprobamos que se conecto correctamente 

            if(con != null)
            {
                string consulta = "SELECT tipodispositivo.Id_tipodispositivo,";
            }

        }
    }
}
