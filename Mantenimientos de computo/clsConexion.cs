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
            cadenaConeccion = "Server=localhost; Database=mantenimientos_computo;Uid=root;Pwd=;Port=3306;";
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
