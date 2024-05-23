// Dati in input due numeri interi, calcolare la somma e visualizzare il risultato

//input

Console.Write("Inserisci un numero intero: ");
string tmp=Console.ReadLine(); //"1" => 1
int n1=int.Parse(tmp);

Console.Write("Inserisci un secondo numero intero: ");
tmp = Console.ReadLine(); //"1" => 1
int n2= int.Parse(tmp);

//calcoli

int somma = n1 + n2;

//output

Console.WriteLine("La somma è: "+somma);

Console.WriteLine("La somma è: {0}",somma);

Console.WriteLine("{0}+{1}={2}",n1,n2,somma); //specifico c#

Console.WriteLine(n1 + "+" + n2 + "=" + somma); // simil java

Console.WriteLine($"{n1}+{n2}={somma}"); //interpolazione

