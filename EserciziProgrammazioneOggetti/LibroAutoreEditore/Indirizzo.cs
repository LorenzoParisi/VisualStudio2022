using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibroAutoreEditore
{
    internal class Indirizzo
    {
        public string Via { get; set; }
        public string Cap {  get; set; }
        public string Provincia { get; set; }

        public string Citta { get; set; }

        public override string ToString()
        {
            return $"{{{nameof(Via)}={Via}," +
                $"{nameof(Cap)}={Cap}" +
                $"{nameof(Citta)}={Citta}" +
                $"{nameof(Provincia)}={Provincia}}}";
        }
    }
}
