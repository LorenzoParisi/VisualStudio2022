
/*Visualizzare i primi 100 numeri interi positivi
 * 
 * Costrutti:
 * 
 * while : iterazione indefinita - cardinalità: [0, +inf]
 * 
 * do while : iterazine indefinita - cardinalità: [1, +inf]
 * 
 * for : iterazione definita
 * 
 */
//"i++" : incremento (i++  equivale a  i=i+1)


Console.WriteLine("For: ");
for (int i = 0; i < 100; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine("\nWhile: ");
int count = 0;
while (count<100) {
    Console.WriteLine(count);
    count++;
}

Console.WriteLine("\nDo while: ");
int count2 = 0;
do
{
    Console.WriteLine(count2);
    count2++;
}while (count2 < 100);
