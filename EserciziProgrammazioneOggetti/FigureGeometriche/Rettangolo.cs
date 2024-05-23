using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseRettangolo
{
    internal class Rettangolo
    {
        //attributi
        public double Base {  get; set; }
        public double Altezza { get; set; }

        public Rettangolo(double @base, double altezza)
        {
            Base = @base;
            Altezza = altezza;
        }



        //metodi
        public double Perimetro()
        {
            return (Base+Altezza)*2;
        }

        public double Area()
        {
            return Base*Altezza;
        }

        public double Diagonale()
        {
            return Math.Sqrt(Math.Pow(Base,2)+Math.Pow(Altezza,2));
        }

        public override string ToString()
        {
            return $"" +
                $"Base: {Base}" +
                $" Altezza: {Altezza}" +
                $" Perimetro: {Perimetro()}" +
                $" Area: {Area()}" +
                $" Diagonale: {Diagonale()}";
        }
    }
}
