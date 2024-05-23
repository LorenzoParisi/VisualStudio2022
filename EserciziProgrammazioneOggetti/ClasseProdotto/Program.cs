namespace ClasseProdotto
{
    internal class Program
    /*
    Di un prodotto si conoscono: codice, denominazione, descrizione, prezzo, giacenza (numero di pezzi disponibili a magazzino). 
    Si vuole avere la possibilità di creare istanze senza e con tutti i parametri. Si richiede altresì la possibilità di sapere se
    il prodotto è in scorta ovvero se la sua disponibilità a magazzino è inferiore a 10 pezzi oppure esaurita se la sua disponibilità è pari a zero.

    Si consideri una ulteriore classe per fare i test su tre istanze di tipo Prodotto, una con disponibilità normale, una in scorta e una esaurita.
     */
    {
        static void Main(string[] args)
        {

            Prodotto p1 = new Prodotto()
            {
                Codice = 123,
                Denominazione = "Pomodoro",
                Descrizione= "Rosso",
                Prezzo = 1.25
            };

            Console.WriteLine(p1);
            if (p1.IsEsaurito())
                Console.WriteLine($"Il prodotto {p1.Denominazione} non è disponibile.");

            Prodotto p2 = new Prodotto(234, "Zucchine", "Verde", 2.13, 8);
            Console.WriteLine(p2);
            if (p2.IsInScorta())
                Console.WriteLine($"Il prodotto {p2.Denominazione} è in scorta.");

            Prodotto p3 = new Prodotto(451, "Peperone", "Giallo", 1.25, 15);
            Console.WriteLine(p3.ToString());
        }
    }
}
