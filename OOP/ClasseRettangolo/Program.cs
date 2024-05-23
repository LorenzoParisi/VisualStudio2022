namespace ClasseRettangolo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Il Rettangolo!");
            
            Rettangolo r = new Rettangolo();
            Console.Write("Base: ");
            r.Base=Convert.ToDouble(Console.ReadLine());
            Console.Write("Altezza: ");
            r.Altezza = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Dati del Rettangolo");
            Console.WriteLine(r.Stampa());

        }
    }
}
