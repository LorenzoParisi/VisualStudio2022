using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solidi
{
    internal class Cono:Solido
    {
        public double Raggio { get; set; }
        public double Altezza { get; set;}

        public Cono(double raggio, double altezza, double pesoSpecifico) : base(pesoSpecifico)
        {
            Raggio = raggio;
            Altezza = altezza;
        }
        public override double Volume()
        {
            return (Math.PI*(Math.Pow(Raggio,2))*Altezza)/3;
        }

        public override string ToString()
        {
            return $"\n - Cono -\n" +
                $"Raggio: {Raggio} " +
                $"Altezza: {Altezza}" + base.ToString();
        }

    }
}
