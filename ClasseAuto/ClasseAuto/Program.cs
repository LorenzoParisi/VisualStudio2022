namespace ClasseAuto
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
        Auto a1 = new Auto("Fiat","Panda",1200,Alimentazione.Diesel,"Blu",50);
        Console.WriteLine(a1.ToString());

       /*
        Esercizio - AutomaAuto

        Si consideri l'esercizio ClasseAuto. 

        Si vuole creare un automa che mette a disposizione tre azioni: accelera, frena e esci. 

        Se l'auto accelera allora aumenta la velocità attuale di 10 km/h, mentre l'azione frena diminuisce la velocità attuale di 5 km/h. 

        Creare un menu testuale per poter scegliere una delle seguenti azioni:

        1 - accelera

        2 - frena

        0 - esci

        Si consideri che: 

        l'auto in fase di avvio del programma viaggia a 50 km/h
        ad ogni azione richiesta viene stampata la velocità attuale dell'auto
        se l'auto supera la velocità 130 km/h viene restituito il messaggio: Rallenta! Stai andando troppo forte
        */
        

        
        }
    }
}
