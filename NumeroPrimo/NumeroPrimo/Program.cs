/*
 Dato in input un numero intero (positivo e maggiore di 1), stabilire se si tratta di un numero primo
 */

Console.WriteLine("Inserire un numero intero positivo e maggiore di 1:");
int n=int.Parse(Console.ReadLine());

bool flag =false; //false n non ha divisori, quindi n è un numero primo

for (int i=2; i<n; i++)
    if(n%i==0)
    {
        flag = true;
        break; //istruzione che consente l'uscita dal ciclo for

    }

if (!flag)
    Console.WriteLine($"{n} è un numero primo");
else Console.WriteLine($"{n} non è un numero primo");