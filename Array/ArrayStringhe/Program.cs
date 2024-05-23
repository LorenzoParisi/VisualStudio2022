/*
riempire un array con i nomi giorni della settimana (1:lunedì, 2:martedi, ecc..)
dato in input stampare un numero da 1 a 7 stampare il relativo giorno della settimana
 */

string[] giorni = { "Lunedì", "Martedì", "Mercoledì", "Giovedì", "Venerdì", "Sabato", "Domenica"};

Console.WriteLine("Inserisci un numero da 1 a 7:");
int n = int.Parse(Console.ReadLine());

if (n < 1 || n > 7)
    Console.WriteLine("Numero non valido");
else
    Console.WriteLine(giorni[n-1]);