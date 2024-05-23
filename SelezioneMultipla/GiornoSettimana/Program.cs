/*Dato in input un dato nell'intervallo da 1 a 7, visualizzare il giorno della settimana corrispondente
 */

//input

Console.WriteLine("Inserire un numero intero [1,7] :");
int nGiorno = int.Parse(Console.ReadLine());

//output

Console.WriteLine("Il numero corrisponde al giorno di:");
switch (nGiorno)
{
    case 1: Console.WriteLine("Lunedì"); break;
    case 2: Console.WriteLine("Martedì"); break;
    case 3: Console.WriteLine("Mercoledì"); break;
    case 4: Console.WriteLine("Giovedì"); break;
    case 5: Console.WriteLine("Venerdì"); break;
    case 6: Console.WriteLine("Sabato"); break;
    case 7: Console.WriteLine("Domenica"); break;
        default: Console.WriteLine("Dato inserito non valido");break;
}