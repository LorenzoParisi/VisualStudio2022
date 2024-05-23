/*
creare un array di numeri reali di dimensione 10 (celle) precaricato
calcolare la somma e stampare il risultato
visualizzare posizione e valore
 */

//dichiarare l'array di numeri reali
double[] numeri = {3,5,5,4,45,4,32,4,23,5,23,5,235,12.25,36.25,89.5,14.75,1.25,3.25,6,95.5,9,4};

//fare la somma dei valori degli array
double somma =0;
for (int i = 0; i < numeri.Length; i++)
somma += numeri[i]; //somma = somma + numeri [i]

Console.WriteLine($"Somma: {somma}");
//visualizzare risultato

Console.WriteLine("Stampa array:");
for (int i = 0;i < numeri.Length; i++)
    Console.WriteLine($"{i}: {numeri[i]}");