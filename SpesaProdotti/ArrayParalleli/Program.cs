/*
 dati in input denominazione, prezzo, quantità di n prodotti
calcolare il subtotale per ogni prodotto e il totale finale da pagare.

visualizzare i risultati a forma di scontrino

prodotto   prezzo unitario   quantità   subtotale
prodotto 1
prodotto 2
...
prodotto n
totale: ?? euro

 */


namespace ArrayParalleli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //numero di prodotti da inserire
            Console.Write("Quanti prodotti devi inserire: ");
            int n = int.Parse(Console.ReadLine());

            //dichiarazione dell'array paralleli
            string[] prodotti = new string[n];
            double[] prezzi = new double[n];
            int[] quantita = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Prodotto: ");
                prodotti[i] = Console.ReadLine();
                Console.Write("Prezzo unitario: ");
                prezzi[i] =double.Parse(Console.ReadLine());
                Console.Write("Quantità: ");
                quantita[i] = int.Parse(Console.ReadLine());

            }
            double totale = 0;
            double subtotale = 0;
            Console.WriteLine("Prodotto\tPrezzo unitario\tQuantità\tSubtotale:");
            for (int i = 0;i < n; i++)
            {
                subtotale = prezzi[i] * quantita[i];
                totale += subtotale;
                Console.WriteLine($"{prodotti[i]}\t{prezzi[i]}\t{quantita[i]}\t{subtotale} euro");
                
            }
            Console.WriteLine($"Totale: {totale} euro");
        }
    }
}
