//Dati in input un carattere visualizzare la sua posizione intera nel codice ASCII

//input

Console.WriteLine("Inserisci un carattere: ");
char c = char.Parse(Console.ReadLine()); //esempi di char 'a' , '\n' , '\t'

int pos=(int)c;

Console.WriteLine($"Carattere inserito: {c}");

Console.WriteLine($"Posizione ASCII: {pos}");