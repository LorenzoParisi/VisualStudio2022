/*dato in input un numero intero, appartenente all'intervallo [1, 12] visuallizare il nome del mese corrispondente
 * 
 * es.
 * input: 3
 * output: marzo
 * 
 * input: 15 (>12)
 * output: dato non valido
 * 
 */

//input
using System.Linq.Expressions;

Console.WriteLine("Inserire un numero intero [1,12] :");
int nMese = int.Parse(Console.ReadLine());

Console.WriteLine("Il numero corrisponde al mese di:");
switch(nMese)
{
    case 1: Console.WriteLine("Gennaio");break;
    case 2: Console.WriteLine("Febbraio"); break;
    case 3: Console.WriteLine("Marzo"); break;
    case 4: Console.WriteLine("Aprile"); break;
    case 5: Console.WriteLine("Maggio"); break;
    case 6: Console.WriteLine("Giugno"); break;
    case 7: Console.WriteLine("Luglio"); break;
    case 8: Console.WriteLine("Agosto"); break;
    case 9: Console.WriteLine("Settembre"); break;
    case 10: Console.WriteLine("Ottobre"); break;
    case 11: Console.WriteLine("Novembra"); break;
    case 12: Console.WriteLine("Dicembre"); break;
    default: Console.WriteLine("Dato inserito non valido"); break;
}