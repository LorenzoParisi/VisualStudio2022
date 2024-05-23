//Dati in input il prezzo, la quantità e la percentuale di sconto di un prodotto, calcolare il totale da scontale, lo sconto effettuato, il totale scontato

//input

Console.WriteLine("Inserire un prezzo di un prodotto: ");
string tmp = Console.ReadLine();
double prezzo1 = double.Parse(tmp);

Console.WriteLine("Inserire la quantità: ");
tmp = Console.ReadLine();
int quantita = int.Parse(tmp);

Console.WriteLine("Inserire la percentuale di sconto: ");
tmp = Console.ReadLine();
double sconto = double.Parse(tmp);

//calcoli

double totale = (double)prezzo1 * quantita;
double scontoEff = (double)totale * sconto / 100;
double totScontato = (double)totale - scontoEff;

//output

Console.WriteLine($"Il prezzo totale è {totale} euro");

Console.WriteLine($"Lo sconto è di {scontoEff:#.##} euro");

Console.WriteLine($"Il prezzo scontato è {totScontato:#.##} euro");


