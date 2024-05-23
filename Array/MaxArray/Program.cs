/*
 riempire un array di 1000 numeri interi generati casualmente
determinare il valore max generato
 */

Random random = new Random();
int n = random.Next(1000);
int[] n = new int[n];
for (int i = 0; i < n; i++)
    Console.WriteLine(i);

//Console.WriteLine($"Valore Max: {max}");