using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mantenimientos_de_computo
{
    internal class clsConexion
    {
        //declaramos la cadena de coneccion para poder conectar con la base 
        //de datos
        private string cadenaConeccion;

        public clsConexion()
        {
            cadenaConeccion = "Server=199.127.60.8; Port=3306; Database=bcorpsov_mantenimientocomputo; Uid=bcorpsov_Alberto; Pwd=BRz2kSWIM8De0Qhg;";
        }
        public MySqlConnection getConnection()
        {
            try
            {
                MySqlConnection conexion = new MySqlConnection(cadenaConeccion);
                conexion.Open();

                return conexion;
            }
            catch
            {
                return null;
            }
        }
    }
}
