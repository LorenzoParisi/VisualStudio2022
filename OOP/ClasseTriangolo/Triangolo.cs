using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseTriangolo
{
    internal class Triangolo
    {
		private double lato1;
        private double lato2;
        private double lato3;
        public double Lato1
		{
			get { return lato1; }
			set { lato1 = value; }
		}            

        public double Lato2
        {
            get { return lato2; }
            set { lato2 = value; }
        }       

        public double Lato3
        {
            get { return lato3; }
            set { lato3 = value; }
        }

        //metodi
        public bool IsCostruibile()
        {
            return lato1 + lato2 > lato3 &&
                lato2 + lato3 > lato1 &&
                lato3 + lato1 > lato2;
        }

        public double Perimetro()
        {
            return lato1 + lato2 + lato3;
        }

        public double Area() { 
        
            double sp=Perimetro()/2;

            return Math.Sqrt(sp * (sp - lato1) * (sp - lato2) * (sp - lato3));
        }

        public string Tipo()
        {
            if (lato1 == lato2 && lato1 == lato3)
                return "Equilatero";
            else if (lato1 == lato2 || lato1 == lato3 || lato2 == lato3)
                return "Isoscele";
            return "Scaleno";
        }

        public string Stampa()
        {
            if (!IsCostruibile())
                return "Triangolo non costruibile";

            return $"" +
                $"\nLato1: {Lato1}" +
                $"\nLato2: {Lato2}" +
                $"\nLato3: {Lato3}" +
                $"\nPerimetro: {Perimetro()}" +
                $"\nArea: {Area()}" +
                $"\nTipo: {Tipo()}"
                ;
        }
    }
}
