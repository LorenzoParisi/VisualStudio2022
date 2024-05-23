using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseProdotto
{
    internal class Prodotto
    {

        public int Codice {  get; set; }
        public string Denominazione { get; set; }
        public string Descrizione { get; set; }
        public double Prezzo { get; set; }
        public int Giacenza { get; set; }

        public Prodotto(int codice, string denominazione, string descrizione, double prezzo, int giacenza)
        {
            Codice = codice;
            Denominazione = denominazione;
            Descrizione = descrizione;
            Prezzo = prezzo;
            Giacenza = giacenza;
        }

        public Prodotto() { }

        public bool IsInScorta()
        {
            return (Giacenza < 10 && Giacenza > 0);
        }

        public bool IsEsaurito()
        {
            return Giacenza == 0;
        }

        public override string ToString()
        {
            return $"{nameof(Codice)}={Codice.ToString()}" +
                $"{nameof(Denominazione)}={Denominazione}" +
                $"{nameof(Descrizione)}={Descrizione}" +
                $"{nameof(Prezzo)}={Prezzo.ToString()}" +
                $"{nameof(Giacenza)}={Giacenza.ToString()}";
        }
    }
    }

    }
