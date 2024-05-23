using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibroAutoreEditore
{
    /*Dell'editore si conoscono le seguenti informazioni: ragione sociale, indirizzo (via, cap, provincia), telefono, email, sito web.
*/
    internal class Editore
    {
        public string RagSoc {  get; set; }
        public Indirizzo Indirizzo { get; set; }
        public string Telefono { get; set; }
        public string SitoWeb { get; set; }

        public Editore(string ragSoc, Indirizzo indirizzo, string telefono, string sitoWeb)
        {
            RagSoc = ragSoc;
            Indirizzo = indirizzo;
            Telefono = telefono;
            SitoWeb = sitoWeb;
        }

        public Editore() { }

        public override string ToString()
        {
            return $"{{{nameof(RagSoc)}={RagSoc}" +
                $"{nameof(Indirizzo)}={Indirizzo}" +
                $"{nameof(Telefono)}={Telefono}" +
                $"{nameof(SitoWeb)}={SitoWeb}}}";
        }
    }
}
