// Dati in input due numeri reali, calcolare la somma e visualizzare il risultato

//input

Console.Write("Inserisci un numero reale: ");
string tmp = Console.ReadLine(); //"1" => 1
double n1 = double.Parse(tmp);

Console.Write("Inserisci un secondo numero reale: ");
tmp = Console.ReadLine(); //"1" => 1
double n2 = double.Parse(tmp);

//calcoli

double somma = n1 + n2;

//output

Console.WriteLine("La somma è: " + somma);

Console.WriteLine($"{n1}+{n2}={somma}"); //interpolazione
