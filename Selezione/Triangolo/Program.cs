/*
Dati in input 3 numeri interi
Calcolare il perimetro, l'area (formula di Erone)
Il tipo di triangolo (equilatero | isoscele | scaleno)

Visualizzare i risultati

*/

using System.ComponentModel.Design;
using System.Drawing;

double l1,l2,l3;
Console.WriteLine("Inserire la misura del primo lato:");
l1 = double.Parse(Console.ReadLine());
Console.WriteLine("Inserire la misura del secodno lato:");
l2 = double.Parse(Console.ReadLine());
Console.WriteLine("Inserire la misura del terzo lato:");
l3 = double.Parse(Console.ReadLine());

//calcoli

double perimetro = l1 + l2 + l3;
double semiperimetro = perimetro / 2;
double area = Math.Sqrt(semiperimetro*(semiperimetro-l1)*(semiperimetro-l2)*(semiperimetro-l3)); //formula di erone


//output
string msg = $"\nRisultati:" +
    $"\nArea: {area}" +
    $"\nPerimetro: {perimetro}";

if (l1 + l2 > l3 && l2 + l3 > l1 && l3 + l1 > l2)
{
    Console.WriteLine(msg);

    if (l1 != l2 && l2 != l3 && l1 != l3)
        Console.WriteLine("Triangolo Scaleno");

    else if (l1 == l2 && l2 == l3 && l1 == l3)
        Console.WriteLine("Triangolo Equilatero");

    else
        Console.WriteLine("Triangolo Isoscele");
}
else
    Console.WriteLine("\nNon è possile calcolare con i dati inseriti");