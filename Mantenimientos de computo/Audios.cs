using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mantenimientos_de_computo
{
    public static class Audios
    {
        private static bool accesibilidad;
        static Audios()
        {
            accesibilidad = false; // Inicializa la variable accesibilidad como false, indicando que el audio no está activado por defecto
        }
        public static bool Accesibilidad
        {
            get { return accesibilidad; }
            set { accesibilidad = value; } // Permite cambiar el estado de la variable accesibilidad desde fuera de la clase
           
        }
       
    }
}
