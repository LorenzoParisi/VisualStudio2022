/*
creare un array di numeri interi di dimensione 5 (celle)
visualizzare posizione e parole di tutte le celle dell'array
 */

//dichiarare un array

int[] numeri = new int[5];

//scrittura su array
numeri[0] = 12;
numeri[1] = -4;
numeri[2] = 5;
numeri[3] = 98;
numeri[4] = -15;

//lettura
for (int i = 0; i < 5; i++)
Console.WriteLine($"{i}: {numeri[i]}");