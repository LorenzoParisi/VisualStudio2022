namespace ClasseTriangolo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangolo t = new Triangolo();

            Console.WriteLine("Il Triangolo!");
            Console.Write("Lato1: ");
            t.Lato1=Convert.ToDouble(Console.ReadLine());
            Console.Write("Lato2: ");
            t.Lato2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Lato3: ");
            t.Lato3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(t.Stampa());

        }
    }
}
