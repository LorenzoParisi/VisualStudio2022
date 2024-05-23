using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibroAutoreEditore
{
    internal class Libro
    /*
     Del libro si conoscono le seguenti informazioni: isbn, titolo, autori, editore, numero di pagine, anno di pubblicazione. 
     */
    /*Il prezzo del libro è dato dal seguente calcolo: costo fisso di stampa che ammonta a 5.05 euro più il costo dato dalla stampa
    delle pagine dove il costo per ogni pagina ammonta a 0.15 euro. 
    */
    {

        public string ISBN { get; set; }
        public string Titolo { get; set; }
        public Autore[] Autore { get; set; }
        public Editore Editore { get; set; }
        public int NumPage { get; set; }
        public string AnnoPub { get; set; }

        public double CostoPagine()
        {
            return NumPage * 0.15;
        }

        public double PrezzoTot()
        {
            return 5.05 + CostoPagine();
        }
        
        private string FormatStampaAutori()
        {
            string elencoAutori = "";
            for (int i = 0; i < Autore.Length; i++)
            {
                elencoAutori += (elencoAutori.Length != 0 ? ", " : " ") + Autore[i].Nominativo();
            } return elencoAutori;
        } 
        public string StampaDettaglio()
        { string elencoAutori = "";
            for (int i = 0;i<Autore.Length; i++)
            {
                elencoAutori += (elencoAutori.Length != 0 ? ", " : " ") + Autore[i].Nominativo();
            }
            return $"" +
                   $"ISBN: {ISBN}" +
                   $"\nTitolo: {Titolo}" +
                   $"\nAutori: {FormatStampaAutori()}" +
                   $"\nEditore: {Editore.RagSoc}" +
                   $"\nAnno di pubblicazione: {AnnoPub}" +
                   $"\nPrezzo: {PrezzoTot()} euro";

        }
        public override string ToString()
        {
            return $"{{{nameof(ISBN)}={ISBN}" +
                   $"{nameof(Titolo)}={Titolo}" +
                   $"{nameof(Autore)}={Autore}" +
                   $"{nameof(Editore)}={Editore}" +
                   $"{nameof(NumPage)}={NumPage.ToString()}" +
                   $"{nameof(AnnoPub)}={AnnoPub.ToString()}}}" +
                   $"Prezzo= {PrezzoTot()}";
        }
    }



}
