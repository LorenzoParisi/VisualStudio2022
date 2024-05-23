using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matite
{
    internal class MatitaConGommino : Matita
    {
        public int gommino { get; private set; } = 10;

        public MatitaConGommino(string marca, string modello) : base(marca, modello)
        {
            gommino = 10;
        }
        
        public void Cancella()
        {
            gommino -= 1;
        }

        public override string ToString()
        {
            return
                $"Marca= {marca} " +
                $"Modello= {modello} " +
                $"Lunghezza= {lunghezza.ToString()} " +
                $"Gommino= {gommino.ToString()}";
        }
    }
}
