using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solidi
{
    internal abstract class Solido
    {
        public double PesoSpecifico { get; private set; }

        public Solido(double pesoSpecifico) { 
        PesoSpecifico = pesoSpecifico;
        }

        //definizione del metodo peso
        public double Peso()
        {
            return PesoSpecifico*Volume();
        }

        public abstract double Volume();

        public override string ToString()
        {
            return $" Peso Specifico: {PesoSpecifico.ToString()}" +
                $" Peso: {Peso()}" +
                $" Volume: {Volume()}";
        }
    }
}
