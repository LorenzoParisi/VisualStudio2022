/*
Dati in input due numeri interi
stabilire se il primo è un multiplo del secondo

Visualizzare n multiplo di N

 */
int n;
Console.WriteLine("Inserire un numero:");
n= int.Parse(Console.ReadLine());

int N;
Console.WriteLine("Inserire un secondo numero:");
N= int.Parse(Console.ReadLine());

int risultato = n / N;

if (n % N == 0)
    Console.WriteLine("Multiplo");
else
    Console.WriteLine("Non Multiplo");

