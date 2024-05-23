using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azienda
{
    internal abstract class Dipendente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public double PagaOraria { get; set; }
        public int OreLavorative { get; set; }

        public Dipendente(string nome, string cognome, double pagaOraria, int oreLavorative)
        {
            Nome = nome;
            Cognome = cognome;
            PagaOraria = pagaOraria;
            OreLavorative = oreLavorative;
        }

        public virtual double Stipendio()
        {
            return PagaOraria * OreLavorative;
        }

        public override string ToString()
        {
            return $" Nome: {Nome}  - " +
                $"Cognome: {Cognome} - " +
                $"Paga oraria: {PagaOraria} - " +
                $"Ore lavorative: {OreLavorative} - " +
                $"Stipendio: {Stipendio()}\n";

        }

    }

}
