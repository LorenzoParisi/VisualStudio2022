using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matite
{
    internal class Matita
    {
        public string marca {  get; set; }
        public string modello { get; set; }

        public double lunghezza { get; set; } = 20;

        public Matita(string marca, string modello)
        {
            this.marca = marca;
            this.modello = modello;
        }

        public Matita () { } 

        public void Tempera()
        {   
            if (lunghezza > 0)
             lunghezza -= 0.5;

            if (lunghezza < 0)
                lunghezza = 0;
        }

        public override string ToString()
        {
            return $"Marca= {marca} " +
                $" Modello= {modello} " +
                $" Lunghezza= {lunghezza.ToString()}";
        }
    }
}
