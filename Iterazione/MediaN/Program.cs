/*
Calcolare l'età media della classe
 */

Console.WriteLine("Inserire la quantità di alunni: ");
int numStud =int.Parse(Console.ReadLine());

int age, somma = 0;

for (int i = 0; i < numStud; i++)
{
    do
    {
        Console.WriteLine("Inserire l'età: ");
        age = int.Parse(Console.ReadLine());
        if (age <= 0) ;
        Console.WriteLine("Dato non valido");
    } while (age <= 0);
    somma += age; //somma = somma+age
}

double media = (double)somma / numStud;

Console.WriteLine($"Eta media: {media}");
