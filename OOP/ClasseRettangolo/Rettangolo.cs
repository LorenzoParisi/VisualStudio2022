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
        private double @base;
        private double altezza;

        //proprietà
        public double Base
        {
            get { return @base; }
            set { @base = value; }
        }

        public double Altezza
        {
            get { return altezza; }
            set { altezza = value; }
        }

        //metodi
        public double Perimetro()
        {
            return (@base+altezza)*2;
        }

        public double Area()
        {
            return @base*altezza;
        }

        public double Diagonale()
        {
            return Math.Sqrt(Math.Pow(@base,2)+Math.Pow(altezza,2));
        }

        public string Stampa()
        {
            return $"" +
                $"\nBase: {Base}" +
                $"\nAltezza: {Altezza}" +
                $"\nPerimetro: {Perimetro()}" +
                $"\nArea: {Area()}" +
                $"\nDiagonale: {Diagonale()}"
                ;
        }
    }
}
