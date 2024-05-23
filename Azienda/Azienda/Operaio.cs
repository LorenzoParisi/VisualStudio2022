using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azienda
{
    enum MansioneOperaio { INSTALLATORE, MANUTENTORE} 
    internal class Operaio : Dipendente
    {
        public MansioneOperaio Mansione { get; set; }
        public int Missione { get; set; }

        public Operaio(MansioneOperaio mansione, string nome, string cognome, double pagaOraria, int oreLavorative, int missione) : base(nome, cognome, pagaOraria, oreLavorative)
        {
            Mansione = mansione;
            Missione = missione;
        }

        public override double Stipendio()
        {
            double bonus = 0;
            switch (Mansione)
            {
                case MansioneOperaio.INSTALLATORE: bonus = 185; break;
                case MansioneOperaio.MANUTENTORE: bonus = 230; break;
                default: return bonus;
            }
            return PagaOraria * OreLavorative + bonus * Missione;
        }

        public override string ToString()
        {
            return $"Mansione: {Mansione} - " +
                $"Missioni: {Missione}  -" +
                base.ToString();
        }
    }
}
