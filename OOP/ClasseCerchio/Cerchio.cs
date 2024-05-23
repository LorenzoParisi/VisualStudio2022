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
        //Information hidden
        private double raggio;

        //getters e setters

        //proprietà
        public double Raggio
        {
            get { return raggio; }
            set { raggio = value; }
        }

        //metodi
        public double Diametro()
        {
            return raggio * 2;
        }

        public double Circonferenza()
        {
            return 2*raggio*Math.PI;
        }

        public double Area()
        {
            return Math.PI * raggio * raggio;
        }
    }
}
