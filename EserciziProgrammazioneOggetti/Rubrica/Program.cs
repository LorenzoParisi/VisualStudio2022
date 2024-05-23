using System.Net.Http.Headers;

namespace Rubrica
{
    internal class Program
    {
        /*
Realizzare una classe per rappresentare la tipica scheda dati di un contatto (un cliente, un amico ecc.) 
normalmente disponibile nei programmi di posta elettronica (la rubrica).

La scheda deve contenere i dati anagrafici essenziali (cognome, nome, indirizzo, telefono ed email). 
L’indirizzo, a sua volta conterrà la via, cap, città e provincia.

Si decide di mettere a disposizione due costruttori: il primo serve a creare un contatto quando sono noti tutti i dati. 
Il secondo quando sono noti solo cognome e nome (i dati mancanti verranno valorizzati con valori di default). 

Definire un metodo per ottenere la scheda completa del contatto che restituisce una stringa che riproduce la seguente etichetta:

Mario Rossi - Via Trento 28, 10100 Torino (TO) Tel. 011-4329512 - email: RossiM@tuttoweb.it

Nel main dell’ipotetico programma creare due contatti (uno con un costruttore ed uno con l’altro); 
visualizzare la scheda completa dei due  contatti.
         */
        static void Main(string[] args)
        {

        Contatto c1 = new Contatto { Nome = "Mario", Cognome = "Rossi", Indirizzo = new Indirizzo() { Via = "Via Trento 28", Cap = "10100",Citta="Torino", Provincia = "TO" }, Telefono = "011-4329512", Email = "RossiM@tuttoweb.it" };
        Console.WriteLine(c1.ToString());
        Contatto c2 = new Contatto { Nome = "Luigi", Cognome = "Dromedari"};
        Console.WriteLine(c2.ToString());
        }
    }
}
