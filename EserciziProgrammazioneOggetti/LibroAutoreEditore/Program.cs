using System.Net.Http.Headers;

namespace LibroAutoreEditore
{
    internal class Program
    {
        /*
Del libro si conoscono le seguenti informazioni: isbn, titolo, autori, editore, numero di pagine, anno di pubblicazione. 
Il prezzo del libro è dato dal seguente calcolo: costo fisso di stampa che ammonta a 5.05 euro più il costo dato dalla stampa
delle pagine dove il costo per ogni pagina ammonta a 0.15 euro. 

Dell'autore si conoscono le seguenti informazioni: nome e cognome, email, profilo instagram, facebook. 
Inoltre è possibile ottenere il nominativo come dato abbreviato  del nome e cognome nel seguente modo: N. Cognome.

Dell'editore si conoscono le seguenti informazioni: ragione sociale, indirizzo (via, cap, provincia), telefono, email, sito web.

Per il libro è prevista una stampa dettaglio, così organizzata:

ISBN:

Titolo:

Autori: [nominativo] 

Editore: [ragione sociale]

Anno di pubblicazione:

Numero pagine:

Prezzo: 

Verificare il corretto funzionamento degli oggetti fornendo degli esempi
         */

        static void Main(string[] args)
        {

            Autore a1 = new Autore {Nome = "Giorgio", Cognome = "Caluso", Email = "a1.libero.it", Facebook = "@GioCar", Instagram="!GioCarInsta"};
            Autore a2 = new Autore { Nome = "Carmelo", Cognome = "Gobbro", Email = "a2.libero.it", Facebook = "@Gobbrino", Instagram = "!GobbrInsta" };
            Autore a3 = new Autore { Nome = "Lillo", Cognome = "Marto", Email = "a3.libero.it", Facebook = "@LiMarto", Instagram = "!LInsta" };

            Editore e1 = new Editore { RagSoc = "", Indirizzo = new Indirizzo() { Via= "Piero Mammo", Cap="18399"}, SitoWeb="edit1.it", Telefono="312 122 1321"};
            Editore e2 = new Editore { RagSoc = "", Indirizzo = new Indirizzo() { Via = "Mamolle", Cap = "11219" }, SitoWeb = "edit2.it", Telefono = "341 122 1351" };

            Libro l1 = new Libro
            {
                ISBN = "123902190391",
                AnnoPub = "2023",
                NumPage = 525,
                Titolo = "Libro bello",
                Autore = new Autore[] {a1,a2,a3},
                Editore = e1
            };

            Libro l2 = new Libro
            {
                ISBN = "4235021912391",
                AnnoPub = "2013",
                NumPage = 55,
                Titolo = "Libra",
                Autore = new Autore[] { a1, a2, a3 },
                Editore = e2
            };

            Console.WriteLine(l1);
            Console.WriteLine(l2);
        }
    }
}
