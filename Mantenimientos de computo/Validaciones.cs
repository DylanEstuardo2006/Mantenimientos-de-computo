using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mantenimientos_de_computo
{
    public  class Validaciones
    {
        


         public Validaciones()
        {
            
        }


        public  void ValidarLetras(KeyPressEventArgs e)
        {

            if (Char.IsLetter(e.KeyChar)) // Permite el uso de letras 
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar)) // Permite el uso de espacios en blanco
            {
                e.Handled = false;
            }

            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        public  void ValidarNumeros(KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar)) // Permite el uso de la tecla de retroceso
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true; // Bloquea cualquier otro carácter que no sea un número o control
            }
        }

        public void ValidarSeparadores(KeyPressEventArgs e)
        {
            if(Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true; //Bloquea si hay un separador (Util para contraseñas y Emails)
            }
        }
        
    }
    
}
