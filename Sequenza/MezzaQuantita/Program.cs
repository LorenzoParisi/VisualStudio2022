//Dati in input il prezzo e la quantità di acquisto di un prodotto e calcolare il totale da pagare e visualizzare il risultato

//input

Console.WriteLine("Inserire un prezzo di un prodotto: ");
string tmp = Console.ReadLine();
double prezzo1 = double.Parse(tmp);

Console.WriteLine("Inserire la quantità: ");
tmp = Console.ReadLine();
int quantita = int.Parse(tmp);

//calcoli

double totale= (double)prezzo1 * quantita;

//output

Console.WriteLine($"Il prezzo totale è: {totale} euro");