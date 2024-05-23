//Dato in input il costo
//applicare la rivalsa (4% del costo da chiedere al cliente)
//imponibile=costo+rivalsa
//calcolare l'iva (aliquota al 22%)
//calcolo il totale lordo
//la ritenuta d'acconto (aliquota 20% dell'imponibile)
//il netto da pagare

/*Visualizzare i risultati

esempio
input: 1000 euro
rivalsa (4%): 40 euro
imponibile : 1040 euro
iva (22%): 228,80 euro
totale lordo: 1268,80 euro

- ritenuta d'acconto (20%): 208 euro

totale netto: 1060,8  euro

*/

//input 
Console.WriteLine("Inserire un prezzo di un prodotto: ");
string tmp = Console.ReadLine();
double prezzo = double.Parse(tmp);

//calcoli
double rivalsa = prezzo * 4 / 100;
double imponibile = prezzo + rivalsa;
double iva = imponibile * 22 / 100;
double totLordo = imponibile + iva;
double ritenuta = imponibile * 20 / 100;
double totNetto = totLordo - ritenuta;

//output

string msg = $"\nConto:\n" +
    $"\nCosto: {prezzo}" +
    $"\nRivalsa (4%): {rivalsa}" +
    $"\nImponibile: {imponibile}" +
    $"\nDi cui IVA (22%): {iva}" +
    $"\nTotale Lordo: {totLordo}" +
    $"\nRitenuta d'acconto (20%): {ritenuta}" +
    $"\nTotale Netto: {totNetto}";

Console.WriteLine(msg);