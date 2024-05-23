/*
 lanciare un dado a 6 facce n volte.
visualizzare le frequenze dei lanci
 */ 

Random random = new Random();

Console.WriteLine("Inserire il numero di lanci: ");
int lanci = int.Parse(Console.ReadLine());
int f1=0, f2=0, f3=0, f4=0, f5=0, f6=0;

for(int i = 0; i < lanci; i++)
{
    switch (random.Next(0,6)+1)
    {
        case 1: f1++; break;
        case 2: f2++; break;
        case 3: f3++; break;
        case 4: f4++; break;
        case 5: f5++; break;
        case 6: f6++; break;
    }
}

Console.WriteLine($"1: {f1} - Frequenza: {(double)f1/lanci*100}");
Console.WriteLine($"2: {f2} - Frequenza: {(double)f2 / lanci * 100}");
Console.WriteLine($"3: {f3} - Frequenza: {(double)f3 / lanci * 100}");
Console.WriteLine($"4: {f4} - Frequenza: {(double)f4 / lanci * 100}");
Console.WriteLine($"5: {f5} - Frequenza: {(double)f5 / lanci * 100}");
Console.WriteLine($"6: {f6} - Frequenza: {(double)f6 / lanci * 100}");
