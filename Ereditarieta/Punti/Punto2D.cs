using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureGeometriche
{
    internal class Punto2D
    {
     //proprietà

     //public int MyProperty { get; set; } // scivere prop e premere tab
    
     public string? Etichetta {  get; set; } //? --> Nullabile

     public double X {  get; set; }

     public double Y { get; set; }


     //costruttori

     public Punto2D(double x, double y) {
        X = x;
        Y = y;
     }

     public Punto2D(string? etichetta, double x, double y)
        {
            Etichetta = etichetta;
            X = x;
            Y = y;
        }


     //metodi
    public virtual double Distanza()
        {//distanza di questo punto dall'origine degli assi
            Punto2D o = new Punto2D(0, 0);
            return Distanza(o);
        }
        public virtual double Distanza(Punto2D punto)
        {
            return Math.Sqrt(
                Math.Pow(this.X-punto.X,2)+Math.Pow(this.Y-punto.Y,2)
                );
        }

        //overriding
        public override string ToString()
        {
            // P(x,y)
            return $"" +
                   $"{Etichetta}({X},{Y})";
        }
    }
}
