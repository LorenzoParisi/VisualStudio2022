/*
Dato in input un numero intero visualizzare
Positivo | Negativo
 */

//input 
int n;
Console.WriteLine("Inserire un numero: ");
n = int.Parse(Console.ReadLine());

if (n >= 0)
    Console.WriteLine("Positivo");
else
    Console.WriteLine("Negativo");