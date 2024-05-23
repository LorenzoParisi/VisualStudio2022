namespace ClasseEmail
{
    internal class Program
    {
        /*
        Si consideri di vuole gestire un email. Sono richiesti i seguenti dati: DA, A, CC, BCC, Oggetto, Messaggio, Data (default), Priorità  con i valori: BASSA, NORMALE (default) o ALTA. 
        Si ipotizzi che nei campi DA, A CC e BCC si possa inserire solo un indirizzo email.

        Si richiede di creare tre istanze, assegnando per ognuna una priorità differente.
        */
        static void Main(string[] args)
        {
            Mail m1 = new Mail("mittente1@mail.com", "destinatario1@mail.com", "mail@mail.com", "email@mail.com", "Visita medica", "Messaggio urgente", DateTime.Now, Priorita.Alta);
            Console.WriteLine(m1.ToString());

            Mail m2 = new Mail(){DA="mittente2@mail.com",A= "destinatario2@mail.com", CC="mail@mail.com", Oggetto="Oggetto", Messaggio="Messaggio", Data=DateTime.Now, Priorita= Priorita.Normale};
            Console.WriteLine(m2.ToString());

            Mail m3 = new Mail() {DA="mittente3@mail.com", A="destinatario3@mail.com", Oggetto="1000esimo cliente", Messaggio="Rispondi subito per riscuotere il premio", Data=DateTime.Now, Priorita=Priorita.Bassa};
            Console.WriteLine(m3.ToString());
        }


        //array di oggetti
    }
}
