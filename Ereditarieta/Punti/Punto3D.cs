using FigureGeometriche;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punti
{
    internal class Punto3D : Punto2D
    {
        public double Z { get; set; }

        public Punto3D(double x, double y, double z) : base(x, y)
        {
            Z = z;
        }

        public Punto3D(string etichetta, double x, double y, double z) : base(etichetta, x, y)
        {
            Z = z;
        }

        public override double Distanza()
        {
            Punto3D o = new Punto3D(0, 0, 0);
            return base.Distanza(o);
        }

        public new double Distanza(Punto3D punto)
        {
            return Math.Sqrt(Math.Pow(this.X - punto.X, 2)
                    + Math.Pow(this.Y - punto.Y, 2)
                    + Math.Pow(this.Z - punto.Z, 2));
        }

        public override string ToString()
        {
            // P(x,y)
            return $"" +
                   $"{Etichetta}({X},{Y},{Z})";
        }
    }
}
