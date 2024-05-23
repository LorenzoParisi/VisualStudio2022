/*
 Effettuare le estrazioni dei numeri di una ruota del lotto
estrarre 5 numeri tra 1 e 90
 */

Random random = new Random(); //funzione che genera numeri casuali

int inf = 1;
int sup = 90;
int e1, e2, e3, e4, e5;

e1 = random.Next(inf, sup);
do
{
    e2 = random.Next(inf, sup);
} while (e1==e2);

do
{
    e3 = random.Next(inf, sup);
} while (e1 == e3|| e3==e2);

do
{
    e4 = random.Next(inf, sup);
} while (e1 == e4|| e4==e3|| e4==e2);

do
{
    e5 = random.Next(inf, sup);
} while (e1 == e5||e5==e2||e5==e4||e5==e3);


Console.WriteLine("Numeri estratti:");
Console.WriteLine($"- {e1}");
Console.WriteLine($"- {e2}");
Console.WriteLine($"- {e3}");
Console.WriteLine($"- {e4}");
Console.WriteLine($"- {e5}");