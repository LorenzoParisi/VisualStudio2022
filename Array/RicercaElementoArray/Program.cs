/*
 generare casualmente un array di 100 numeri interi intervallo -100, 100

 da input un numero intero dall'intervallo -100 100 da ricercare nell'array

 restituire uno dei seguenti messaggi:

numero trovato in posizione ? | numero non trovato

se il numero è presente più volte nell'array, viene restituito solo la prima posizione utile

 */
Random random = new Random();
int numeri = random.Next(-100, 100);

Console.WriteLine("Inserire un numero da ricercare:");
int n = int.Parse(Console.ReadLine());

int pos = -1;
for (int i = 0; i < numeri.Lenght; i++)
    if (numeri[i] == n)
    {

    }
    