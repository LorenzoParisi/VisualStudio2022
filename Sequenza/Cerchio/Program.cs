//Dato in input il raggio di un cerchio calcolare l'area e la circonferenza e il diametro

//input

Console.WriteLine("Inserire il raggio:");
string tmp = (Console.ReadLine());
double raggio = double.Parse(tmp);

//calcoli

double diametro = raggio * 2;
double area = raggio * raggio * Math.PI;
double circonferenza = 2 * Math.PI * raggio;

Console.WriteLine($"Area: {area}");
Console.WriteLine($"Diametro: {diametro}");
Console.WriteLine($"Circonferenza: {circonferenza}");


//Formula alternativa

string msg = $"Risultati:" +  //"msg" è la variabile che contiene tutto il messaggio
    $"\nDiametro: {diametro}" +
    $"\nArea: {area}" +
    $"\nCirconferenza: {circonferenza}";

    Console.WriteLine(msg);
