/*

*/

//input
using System.ComponentModel.Design;

int ore, minuti, secondi;
Console.WriteLine("Inserire 3 numeri:");
ore=int.Parse(Console.ReadLine());
minuti=int.Parse(Console.ReadLine());
secondi=int.Parse(Console.ReadLine());

//output

if (ore > 23 || minuti > 59 || secondi > 59)
{
    if (ore < 10 || minuti < 10 || secondi < 10)
        Console.WriteLine($"0{ore}:0{minuti}:0{secondi}");
}
Console.WriteLine("Sequenza Oraria non valida");



