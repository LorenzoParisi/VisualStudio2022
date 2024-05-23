namespace SchedaTombola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Riempire un array di numeri interi casuali per simulare una scheda della tombola, ad esempio la scheda 17
             Stampare il risultato
             /

            Random random = new Random();
            int[] numeri = new int[15];
            int tmp;

            for (int i = 0; i < 15; i++)
                for (int j = 0; j < 15; j++)
                    while (numeri[i] == numeri[j] && i != j)
            {
                numeri[i] = random.Next(1, 91);
                Console.Write($"[{numeri[i]}] ");
            }
            */

            static int Ordina(int[] array, bool flag=true)
            {
                for (int i = 0; i < array.Length; i++)
                    for (int j = 0; j < array.Length; j++)
                        if (array[i] > array[j])
                        {
                            int tmp = array[i];
                            array[i] = array[j];
                            array[j] = tmp;
                        }
            }
        }
    }
}
