/*Dati in iput due numeri e uno dei seguenti simboli: +, -, *, /, %
 * calcolare l'operazione richiesta e visualizzare l'operazione effettuata e il risultato ottenuto
 * 
 * es.
 * input: 5, 8, *
 * output: Moltiplicazione - Risultato: 45
 */
Console.WriteLine("Inserire due numeri interi: ");

double num1 = int.Parse(Console.ReadLine());
double num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Inserire il simbolo dell'operazione: ");

string operazione = Console.ReadLine();
//char car = char.Parse(Console.ReadLine());


switch (operazione)
{
    case "+": Console.WriteLine($"Addizione - Il risultato è: {num1} + {num2} = {num1 + num2}"); break;
    case "-": Console.WriteLine($"Sottrazione - Il risultato è: {num1} - {num2} = {num1 - num2}"); break;
    case "*": Console.WriteLine($"Moltiplicazione - Il risultato è: {num1} * {num2} = {num1 * num2}"); break;
    case "/": Console.WriteLine($"Divisione - Il risultato è: {num1} / {num2} = {num1 / num2}"); break;
    case "%": Console.WriteLine($"Resto - Il risultato è: {num1} % {num2} = {num1 % num2}"); break;
    default: Console.WriteLine("Operazione non valida"); break;
}
