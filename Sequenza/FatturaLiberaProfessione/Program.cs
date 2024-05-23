//Dato in input l'imponibile, calcolare l'iva (aliquota al 22%), la ritenuta d'acconto (aliquota 20% dell'imponibile) e il netto da pagare

/*Visualizzare i risultati

esempio
input: 1000 euro
imponibile :1000
iva (22%): 220 euro
totale: 1220 euro

- ritenuta d'acconto (20%): 200 euro

totale netto: 1220 - 200 = 1020 euro

*/

//input 
Console.WriteLine("Inserire un prezzo di un prodotto: ");
string tmp = Console.ReadLine();
double prezzo = double.Parse(tmp);

//calcoli

double iva = prezzo * 22 / 100;
double totale = prezzo + iva;
double ritenuta = prezzo * 20 / 100;
double totNetto = totale - ritenuta;

//output

string msg = $"\nConto:\n" +
    $"\nCosto: {prezzo}" +
    $"\nDi cui IVA (22%): {iva}" +
    $"\nTotale: {totale}"+
    $"\nRitenuta d'acconto (20%): {ritenuta}" +
    $"\nTotale Netto: {totNetto}";

Console.WriteLine(msg);