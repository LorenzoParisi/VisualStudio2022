namespace ClasseQuadrato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Object 

            Console.WriteLine("Il Quadrato!");

            //istanza di un oggetto
            Quadrato q = new Quadrato(1.25);            

            Console.WriteLine($"Perimetro: {q.Perimetro()}");
            Console.WriteLine($"Area: {q.Area()}");
            Console.WriteLine($"Diagonale: {q.Diagonale()}");
            
            
            Console.Write("\n\n\nInserisci il lato del quadrato: ");
            string tmp = Console.ReadLine();
            Quadrato q1=new Quadrato(Convert.ToDouble(tmp));
            q1.SetLato(-1.25);
            Console.WriteLine($"Lato: {q1.GetLato()}");

        }
    }
}
