using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    internal class Persona
    {
        //Attributi
        //info hidding
        private string cognome;
        private string nome;
        private DateTime dataNascita;
        private string luogoNascita;
        private Sesso sesso;

        public string Cognome
        {
            get { return cognome; }
            set { cognome = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public DateTime DataNascita
        {
            get { return dataNascita; }
            set { dataNascita = value; }
        }

        public string LuogoNascita
        {
            get { return luogoNascita; }
            set { luogoNascita = value; }
        }


        public Sesso Sesso
        {
            get { return sesso; }
            set { sesso = value; }
        }

        //metodi
        //calcolo età

        public int Eta()
        {
            DateTime oggi = DateTime.Now;

            int eta= oggi.Year-dataNascita.Year;

            //filtro - non hai compiuto gli anni
            if (dataNascita.Month > oggi.Month)
                eta--;
            else if (dataNascita.Month == oggi.Month && dataNascita.Day > oggi.Day)
                eta--;

        return eta;
        }

        //metodi consumer "usa e getta
        public string Stampa()
        {
            return $"" +
                $"Cognome: {Cognome}" +
                $"Nome: {Nome}" +
                $"Data di nascita: {dataNascita.ToShortDateString()} " +
                $"Luogo di nascita: {luogoNascita}" +
                $"Sesso: {sesso} " +
                $"Età: {Eta()}"
                ;
        }
    }
}
