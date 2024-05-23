using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solidi
{
    internal class Sfera:Solido
    {
        public double Raggio { get; set; }

        public Sfera(double raggio, double pesoSpecifico) : base(pesoSpecifico)
        {
            Raggio = raggio;
        }
        public override double Volume()
        {
            return (4/3)*Math.PI*(Math.Pow(Raggio,3));
        }

        public override string ToString()
        {
            return $"\n - Sfera -\n" +
                $"Raggio: {Raggio} " + base.ToString();
        }

    }
}
