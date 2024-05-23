using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace ArrayMenu
{
    internal class Program
    {
        /*Si consideri un array di numeri interi generati in modo casuale con numeri appartenenti all'intervallo [inf, sup]
        di dimensione n, con inf, sup e n dati in input e con le seguenti ipotesi:

        n>0
        inf<sup

        Si vuole scegliere una delle seguenti operazioni:

        1 - stampa dell'array (posizione e valore)

        2 - stampa dei numeri solo positivi (posizione e valore)

        3 - ricerca di un elemento dato in input(output: trovato in posizione oppure non trovato)

        4 - ordina array(usare selection sort)

        5 - media aritmetica dei soli valori positivi e maggiori di zero

        9 - esci dal programma
            */
        static void Main(string[] args)
        {
            Console.Write("Inserire due valori come intervallo:");
            Console.Write("Inserire un valore:");
            int sup = int.Parse(Console.ReadLine());
            Console.Write("Inserire un secondo valore inferiore al precedente:");
            int inf = int.Parse(Console.ReadLine());
            Console.Write("Inserire la dimensione dell'array:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\nScegliere fra le seguenti opzioni: " +
                "\n1 - stampa dell'array (posizione e valore) " +
                "\n2 - stampa dei numeri solo positivi (posizione e valore) " +
                "\n3 - ricerca di un elemento dato in input(output: trovato in posizione oppure non trovato) " +
                "\n4 - ordina array(usare selection sort) " +
                "\n5 - media aritmetica dei soli valori positivi e maggiori di zero " +
                "\n9 - uscire dal programma" +
                "\nInserire il numero dell'opzione:");
            string opzione = Console.ReadLine();

            Random random = new Random();
            int[] numeri = new int[n];

            switch (opzione)
            {
                case "1": 
                    for (int i = 0;i < numeri.Length;i++)
                    {
                        numeri[i] = random.Next(inf,sup) ;
                        if (n > 0 || inf < sup)
                            Console.WriteLine($"Posizione: {i} - Valore: {numeri[i]}");
                    }
                    ; break;

                case "2":
                    for (int i = 0; i < numeri.Length; i++)
                    {
                        numeri[i] = random.Next(inf, sup);
                        if (n > 0 || inf < sup)
                            if (numeri[i]>=0)
                            Console.WriteLine($"Posizione: {i} - Valore: {numeri[i]}");
                    }
                    ; break;

                    case "3":
                    ; break;

                    case "4":
                    ; break;

                    case "5":
                    ; break;

                    case "9":
                    ; break;
                default: Console.WriteLine("Opzione insesistente"); break;
            }
        }
    }
}
