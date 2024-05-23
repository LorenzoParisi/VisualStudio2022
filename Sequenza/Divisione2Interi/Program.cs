// Dati in input due numeri interi, calcolare il quozienta intero, il resto e il quoziente reale

//input

Console.WriteLine("Inserire un numero: ");
string tmp=Console.ReadLine();
int n1 = int.Parse(tmp);

Console.WriteLine("Inserire un secondo numero: ");
tmp = Console.ReadLine();
int n2 = int.Parse(tmp);

//calcoli

int quozIntero = n1 / n2;
int resto = n1 % n2;
double quozReale = (double)n1 / n2; //casting (double restituisce tutti i numeri dietro la virgola)

//risultato

Console.WriteLine($"Quoziente intero: {quozIntero} ");

Console.WriteLine($"Resto: {resto}");

Console.WriteLine($"Quoziente Reale: {quozReale} ");