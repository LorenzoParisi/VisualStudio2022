using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibroAutoreEditore
{
    /*Dell'autore si conoscono le seguenti informazioni: nome e cognome, email, profilo instagram, facebook. 
    Inoltre è possibile ottenere il nominativo come dato abbreviato del nome e cognome nel seguente modo: N.Cognome.*/
    internal class Autore
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Email { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }

        public string Nominativo()
        {
            return Nome.Substring(0, 1).ToUpper() + "." +
                Cognome.Substring(0, 1).ToUpper() +
                Cognome.Substring(1).ToLower();
        }

        public Autore() { }

        public Autore(string nome, string cognome, string email, string facebook, string instagram)
        {
            Nome = nome;
            Cognome = cognome;
            Email = email;
            Facebook = facebook;
            Instagram = instagram;        
        }
    }
}
