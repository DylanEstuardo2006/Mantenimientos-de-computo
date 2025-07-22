using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mantenimientos_de_computo
{
    internal class clsCombobox
    {
        public int Id { get; set; }
        public string Texto { get; set; }

        public override string ToString()
        {
            return Texto;
        }
    }
}
