//Stampare n multipli di m, con n e m dati in iput

Console.WriteLine("Inserisci quanti numeri vuoi stampare:");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Inserisci il multiplo di cui stampare il valore:");
int m= int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
    Console.WriteLine(m * i);
