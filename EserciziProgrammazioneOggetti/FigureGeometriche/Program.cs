using ClasseCerchio;
using ClasseQuadrato;
using ClasseRettangolo;
using ClasseTriangolo;
using System.Security.Cryptography.X509Certificates;

namespace FigureGeometriche
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Figure");


            Punto p = new Punto("P", 0, 2);
            Console.WriteLine(p);
            Console.WriteLine(p.ToString());


            Punto q = new Punto ("Q", 3,2);
            Console.WriteLine(q);

            Console.WriteLine($"OP={p.Distanza()}");
            Console.WriteLine($"OQ={q.Distanza()}");

            Console.WriteLine($"PQ={p.Distanza(q)}");
            Console.WriteLine($"QP={q.Distanza(p)}");

            Punto r =new Punto("R", -2.25, 2.75);

            Triangolo t = new Triangolo(p,q,r);
            Console.WriteLine(t);


            Quadrato q1 = new Quadrato(4);
            Console.WriteLine(q1.ToString());

            Cerchio c1 = new Cerchio(4);
            Console.WriteLine(c1.ToString());

            Rettangolo r1 = new Rettangolo(4, 5);
            Console.WriteLine(r1.ToString());

            Triangolo t1 = new Triangolo(4, 5, 6);
            Console.WriteLine(t1.ToString());
            
        }
    }
}
