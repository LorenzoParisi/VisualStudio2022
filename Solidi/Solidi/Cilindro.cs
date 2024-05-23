using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solidi
{
    internal class Cilindro:Solido
    {
        public double Raggio { get; set; }
        public double Altezza { get; set; }

        public Cilindro(double raggio, double altezza, double pesoSpecifico) : base(pesoSpecifico)
        {
            Raggio = raggio;
            Altezza = altezza;
        }
        public override double Volume()
        {
            return Math.PI * (Math.Pow(Raggio, 2)) * Altezza;
        }

        public override string ToString()
        {
            return $"\n - Cilindro -\n" +
                $"Raggio: {Raggio} " +
                $"Altezza: {Altezza} " + base.ToString();
        }
    }
}
