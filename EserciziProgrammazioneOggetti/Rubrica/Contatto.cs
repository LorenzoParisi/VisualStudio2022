using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubrica
{
    internal class Contatto
    {

    public string Cognome { get; set; }
    public string Nome { get; set; }
    public Indirizzo Indirizzo { get; set;}
    public string Telefono { get; set; }
    public string Email { get; set; }

        public Contatto(string cognome, string nome, Indirizzo indirizzo, string telefono, string email)
        {
            Cognome = cognome;
            Nome = nome;
            Indirizzo = indirizzo;
            Telefono = telefono;
            Email = email;
        }

        public Contatto() { }

        public override string ToString()
        {
            string result = $"{Nome} {Cognome}";

            if (Indirizzo != null)
                result += $" - {Indirizzo}";

            if (!string.IsNullOrEmpty(Telefono))
                result += $" Tel.{Telefono}";

            if (!string.IsNullOrEmpty(Email))
                result += $"email:{Email}";

            return result;
        }
    }
}