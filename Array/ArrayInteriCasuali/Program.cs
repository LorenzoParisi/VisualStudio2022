/*
generare un array di numeri interi
con dimensione e estremi intervallo di dati in input

100

-100

92

somma dei soli numeri strettamente positivi

somma dei soli numeri strettamente negativi

visualizzare l'array generato
*/

//input
using System.ComponentModel;

Console.WriteLine("Quanti numeri vuoi generare?:");
int n =int.Parse(Console.ReadLine());
Console.WriteLine("Inserire un numero intero:");
int sup = int.Parse(Console.ReadLine());
Console.WriteLine("Inserire un secondo numero intero:");
int inf =int.Parse(Console.ReadLine());

//array
int[] numeri = new int[n];

//random
Random random = new Random();
int somma = 0;
for (int i = 0; i < n; i++)
    somma += (numeri[i] > 0 ? numeri[i] : 0);

Console.WriteLine($"Somma: {somma}");

int contaNeg = 0;
for (int i =0; i < numeri.Length; i++)
    if (numeri[i] < 0)
        contaNeg++;

Console.WriteLine($"Conta negativi: {contaNeg}");

Console.WriteLine();
Console.WriteLine("Stampa array");
for (int i = 0;i < numeri.Length; i++)
    Console.WriteLine($"{i}: {numeri[i]}");