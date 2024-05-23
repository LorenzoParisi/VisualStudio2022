/*
 Dati in input il prezzo e la quantità di n prodotto si richiede di calcolare il totale da pagare.
 Visualizzare il risultato

es 
prezzo 10.25 quantità 2
prezzo 9 quantità 3
prezzo 15 quantità 2

Totale: 62.50 euro
 */
using System.Runtime.CompilerServices;

Console.WriteLine("Inserire la quantità di prodotti: ");
int quantitaProd=int.Parse(Console.ReadLine());

double prezzo;
int quantitaSingle;
double totale = 0;

for (int i = 0; i < quantitaProd; i++) ;
{
        Console.WriteLine("Inserisci il prezzo del prodotto: ");
        prezzo = double.Parse(Console.ReadLine());

        Console.WriteLine("Inserisci la quantità del prodotto: ");
        quantitaSingle = int.Parse(Console.ReadLine());

        totale += prezzo*quantitaProd;
}

Console.WriteLine($"Totale: {totale}");