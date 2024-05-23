using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azienda
{
    enum MansioneAmministrativo {CONTABILE, RISORSEUMANE, DIRETTORE}

        internal class Amministrativo : Dipendente
    {
        public MansioneAmministrativo Mansione { get; set; }

        public override double Stipendio()
        {
            double bonus = 0;
            switch (Mansione)
            {
                case MansioneAmministrativo.CONTABILE: bonus=150; break;
                case MansioneAmministrativo.RISORSEUMANE: bonus = 75; break;
                case MansioneAmministrativo.DIRETTORE: bonus = 250; break;
                    default: return bonus;
            }
            return PagaOraria * OreLavorative + bonus;
        }

        public Amministrativo(MansioneAmministrativo mansione, string nome, string cognome, double pagaOraria, int oreLavorative):base(nome,cognome, pagaOraria, oreLavorative)
        {
            Mansione = mansione;
        }

        public override string ToString()
        {
            return $"Mansione: {Mansione} - " + 
                base.ToString();
        }
    }
}
