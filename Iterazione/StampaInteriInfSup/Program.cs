//Dati in iput due estremi di un intervallo di numeri interi (estremo1<estremo2) , stampare tutti i valori dell'intervallo (inclusi gli estremi)

// es. [-10; 10]  -->  -10, -9, ..., 9, 10

Console.WriteLine("Inserisci due numeri interi da usare come estremi:");
int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Valori ottenuti: ");
for (int i = n; i <= m; i++)
{
    Console.WriteLine(i);
}