/*Dati in input il costo di un certo prodotto, calcolare l'IVA (aliquota al 22%) e il totale da pagare

Visualizzare i risultati

Esempio: 
costo : 100 euro
iva (22%) : 22 euro
Totale : 122,00 euro
 */

//input 
Console.WriteLine("Inserire un prezzo di un prodotto: ");
string tmp = Console.ReadLine();
double prezzo = double.Parse(tmp);

//calcoli

double iva = prezzo * 22 / 100;
double totale = prezzo + iva;

//output

string msg = $"Conto:" +
    $"\nCosto: {prezzo}" +
    $"\nDi cui IVA (22%): {iva}" +
    $"\nTotale: {totale}";
Console.WriteLine(msg);