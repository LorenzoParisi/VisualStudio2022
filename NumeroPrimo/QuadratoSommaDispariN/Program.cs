/*
1=1
4=1+3
9=1+3+5
16=1+3+5+7
25=1+3+5+7+9
11=? => 11 numeri dispari sommati in ordine crescente (11 alla seconda 121=1+3+5+...+21)
 */

Console.WriteLine("Inserire un numero intero positivo: ");
int n= int.Parse(Console.ReadLine());

int somma = 0;
string txt=string.Empty;
for (int i = 0; i < n; i++)
{
    somma += 2 * i + 1;
    txt += (txt.Length!=0 ? "+":"") + (2 * i + 1);
}

Console.WriteLine($"{somma}={txt}");
