namespace Quadrilateri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrilatero q1 = new Quadrilatero(2,4,5.5,6.1);
            Console.WriteLine(q1);

            Rettangolo r1 = new Rettangolo(2.4, 3.25);
            Console.WriteLine(r1);

            Quadrato qu1 = new Quadrato(5);
            Console.WriteLine(qu1);
        }
    }
}
