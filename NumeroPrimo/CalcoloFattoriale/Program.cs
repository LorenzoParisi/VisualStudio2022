/*
 Dato in input un numero intero positivo, calcolare il fattoriale, visualizzare il risultato

input n=> n!=n*(n-1)*(n-2)* * * 2 * 1

es. 3!= 3*2*1=6
5!= 5*4!=5*4*3!=20*6=120

11! => 11!=?
 */

Console.WriteLine("Inserire un numero intero positivo: ");
int n = int.Parse(Console.ReadLine());

int fatt = 1;
for (int i = n; i > 1; i--)
fatt *= i; // fatt= fatt*i

Console.WriteLine($"{n}!={fatt}");
