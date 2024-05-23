using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseCerchio
{
    internal class Cerchio
    {
        //attributi
        public double Raggio { get; set; }

        public Cerchio(double raggio)
        { 
            Raggio = raggio;
        }

        //metodi
        public double Diametro()
        {
            return Raggio * 2;
        }

        public double Circonferenza()
        {
            return 2*Raggio*Math.PI;
        }

        public double Area()
        {
            return Math.PI * Raggio * Raggio;
        }

        //overriding

        public override string ToString()
        {
            return $"" +
                   $"Raggio: {Raggio}" +
                   $" Diametro: {Diametro()}"+
                   $" Circonferenza: {Circonferenza()}" +
                   $" Area: {Area()}";
        }
    }
}
