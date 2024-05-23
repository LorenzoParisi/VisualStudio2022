Random random = new Random();
Console.Write("Inserire un valore:");
int n = int.Parse(Console.ReadLine());
int[] numeri = new int[n];
int somma = 0;

for (int i = 0; i < numeri.Length; i++)
{
    numeri[i] = random.Next(-100, 101);
    if (numeri[i] > 0)
        somma += numeri[i]; 
}
Console.WriteLine($"La somma è: {somma}");