using System.Numerics;

namespace RandomNInteri
{
    internal class Program
     //   Mobile App Developer, Fondamenti di programmazione, Parisi, Lorenzo, 15 aprile 2024
    {
        static void Main(string[] args)
        {
            /*
             dati in input gli estremi di un intervallo, generare N numeri interi random e memorizzarli in un array. 
            Successivamente contare quanti numeri sono multipli di m, con m dato in input.
            Visualizzare l'array generato, quanti numeri sono stati trovati multipli di m e visualizzarli successivamente. 
             */

            /*input
             */
            Console.WriteLine("Inserire il numeri di valori da generare:");
            int n =int.Parse(Console.ReadLine());
            Console.WriteLine("Inserire un numero:");
            int sup = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserire un numero minore del precedente:");
            int inf=int.Parse(Console.ReadLine());
            Console.WriteLine("Inserire il numero per cercare i suoi multipli:");
            int m=int.Parse(Console.ReadLine());

            /*array*/
            Random random = new Random();
            int[] numeri = new int[n] ;
            //stampa valori
            Console.WriteLine("\nValori random degli array:");
            for (int i = 0; i < n; i++)
            {
                numeri[i]= random.Next(inf, sup);
                Console.WriteLine($"[{numeri[i]}]");
            }

            //valori multipli di m
            Console.WriteLine($"\nNumeri multipli di {m}:");
            int multipli = 0;
            for (int i = 0; i < n; i++)
            {
                if (numeri[i] % m == 0)
                    multipli++;
            }
            Console.WriteLine($"{multipli}");

        }
    }
}
