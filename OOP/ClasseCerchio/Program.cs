namespace ClasseCerchio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Il Cerchio!");

            Cerchio c = new Cerchio();

            Console.Write("Inserisci il raggio: ");
            c.Raggio=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Raggio: {c.Raggio}");
            Console.WriteLine($"Diametro: {c.Diametro()}");
            Console.WriteLine($"Circonferenza: {c.Circonferenza()}");
            Console.WriteLine($"Area: {c.Area()}");
        }
    }
}
