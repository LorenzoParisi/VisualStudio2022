using System.Xml.Schema;

Random random = new Random();
int[] numeri = new int[100];

for (int i = 0; i < 100; i++)
{
    numeri[i] = random.Next(-100,101) ;
    if (numeri[i]%10==0)
        if (numeri[i]!=0)
            Console.WriteLine($"{i}[{numeri[i]}]");
}
