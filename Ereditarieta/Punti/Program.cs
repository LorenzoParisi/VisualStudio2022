using FigureGeometriche;

namespace Punti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Punto2D => Punto3D");

            Punto2D p2d = new Punto2D(2,5);
            Console.WriteLine(p2d);

            Punto3D p3d = new Punto3D(3,6,7);
            Console.WriteLine(p3d);

            Punto3D p3dq = new Punto3D(5.5,2.1,7.8);
            Console.WriteLine(p3dq);
            Console.WriteLine($"PQ={p3d.Distanza(p3dq)}");            
        }
    }
}
