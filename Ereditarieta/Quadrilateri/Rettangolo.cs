using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadrilateri
{
    internal class Rettangolo : Quadrilatero
    {
        public Rettangolo(double Base, double Altezza)
            : base(Base, Altezza, Base, Altezza) 
        { }

        public double Area()
        {
            return base.lato1 * base.lato2;
        }

        public double Diagonale() 
        {
            return Math.Sqrt(Math.Pow(base.lato1, 2) + Math.Pow(base.lato2, 2));
        }

        public override string ToString()
        {
            return $"base: {lato1} " +
                $"altezza: {lato2} " +
                $"Perimetro: {Perimetro()} " +
                $"Area: {Area()} " +
                $"Diagonale: {Diagonale()} ";
        }
    }
}
