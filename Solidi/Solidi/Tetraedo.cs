using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solidi
{
    internal class Tetraedo:Solido
    {
        public double Lato { get; set; }

        public Tetraedo(double lato, double pesoSpecifico) : base(pesoSpecifico)
        {
            Lato = lato;
        }

        public override double Volume()
        {
            return (Math.Sqrt(2)/12)*Math.Pow(Lato,3);
        }
        public override string ToString()
        {
            return $"\n - Tetraedo -\n" +
                $"Lato: {Lato} " +
                 base.ToString();
        }
    }
}
