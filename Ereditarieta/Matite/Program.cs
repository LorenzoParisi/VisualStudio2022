namespace Matite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matita m1 = new Matita("Giotto","A5");
            Console.WriteLine(m1);

            m1.Tempera();
            Console.WriteLine(m1);

            MatitaConGommino m2 = new MatitaConGommino("Fabel", "A8");
            Console.WriteLine(m2);

            m2.Tempera();
            m2.Cancella();
            Console.WriteLine(m2);
        }
    }
}
