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
        //information hiding
        private double lato; //lettura e scrittura


        //costruttori
        //costruttore di default
        public Quadrato(double lato) {
            this.lato = lato;
        }

        //getters e setters

        //getter
        public double GetLato()
        {
            return lato;
        }

        //setter
        public void SetLato(double lato)
        {            
            this.lato = lato;
        }


        //metodi
        public double Perimetro()
        {
            double p = lato * 4;
            return p;
        }

        public double Area()
        {
            double a = lato * lato;
            return a;
        }

        public double Diagonale()
        {
            return lato * Math.Sqrt(2);
        }

    }
}
