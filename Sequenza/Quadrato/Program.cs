//Dato in input il lato di un quadrato calcolare l'area, il perimetro e la diagonale

//input

Console.WriteLine("Inserire il lato:");
string tmp=(Console.ReadLine());
double lato=double.Parse(tmp);

//calcoli

double diagonale = lato * Math.Sqrt(2);
double perimetro = lato * 4;
double area = lato * lato;

//output

Console.WriteLine($"Area: {area}");
Console.WriteLine($"Perimetro: {perimetro}");
Console.WriteLine($"Diagonale: {diagonale}");



