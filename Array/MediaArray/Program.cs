/*
 Calcolare la media dei valori di un array di numeri interi generati casualmente all'intervallo [inf, sup]
 solo positivi strettamente

 visualizzare il risultato

 n, inf, sup generati casualmente [-100, 100]

n>0

inf<sup

 */

Random random = new Random();

int inf, sup, n;

    n = random.Next(0, 100)+1;
    inf = random.Next(-100, 101);
sup = random.Next(inf, 101);

int[] numeri = new int[n];

for (int i = 0; i < numeri.Length; i++)
    numeri[i] = random.Next(-100, 101);

int count = 0;
int somma = 0; 

for (int i = 0; i< numeri.Length; i++)
    if (numeri[i] > 0)
    {
        somma += numeri[i];
        count++;
    }
double media = (double)somma / count;
Console.WriteLine($"Media: {media}");
Console.WriteLine($"Num non validi: {count}");

for (int i = 0;i< numeri.Length; i++)
    Console.WriteLine($"{i}: {numeri[i]}");