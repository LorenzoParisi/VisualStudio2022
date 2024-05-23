namespace Persona
{
    internal class Program
    /*
    Definire la classe Persona. Una persona è caratterizzata da un cognome, un nome, una data di nascita, un luogo di nascita e un sesso. 
    Inoltre è previsto determinare la sua età (numero di anni compiuti).
    Determinare tre istanze di Persona. Visualizzare i dati di configurazione e l'età usufruendo di una azione Stampa.
     */
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Istanze di Persona");

            //istanza p1=oggetto 
            Persona p1 = new Persona();
            p1.Cognome = "Lello ";
            p1.Nome = "Marco ";
            p1.DataNascita = new DateTime(2000, 3, 25); //24anni
            p1.LuogoNascita = "Torino ";
            p1.Sesso = Sesso.M;

            Console.WriteLine(p1.Stampa());

            Persona p2 = new Persona()
            {
               Cognome ="Rossi ",
               Nome = "Laura ",
               DataNascita = new DateTime(1999,10,10),
               LuogoNascita = "Genova ",
               Sesso = Sesso.F
            };
            Console.WriteLine(p2.Stampa());
        }
    }
}
