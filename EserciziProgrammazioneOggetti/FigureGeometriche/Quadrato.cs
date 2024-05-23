using FigureGeometriche;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseQuadrato
{
    internal class Quadrato
    {
        //attributi

        public double Lato {  get; set; }

        public Quadrato(double lato)
        {
            Lato = lato;
        }

        //metodi

        public double Perimetro()
        {
            return Lato * 4;
        }
        
        public double Area()
        {
            return Lato*Lato;
        }

        //overriding
        public override string ToString()
        {
            return $"" +
                   $"Lato: {Lato}" +
                   $" Perimetro: {Perimetro()}" +
                   $" Area: {Area()}";
        }
    }
}
