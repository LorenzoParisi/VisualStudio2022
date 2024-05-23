using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseEmail
{
    internal class Mail
    {
        public string DA {  get; set; }
        public string A { get; set; }
        public string CC { get; set; }
        public string BCC { get; set; }
        public string Oggetto { get; set; }
        public string Messaggio { get; set; }
        public DateTime Data { get; set; }
        public Priorita Priorita { get; set; }

        public Mail(string da, string a, string cc, string bcc, string oggetto, string messaggio, DateTime data, Priorita priorita)
        {
            DA = da;
            A = a;
            CC = cc;
            BCC = bcc;
            Oggetto = oggetto;
            Messaggio = messaggio;
            Data = data;
            Priorita = priorita;
        }

        public Mail() { }

        public override string ToString()
        {
            return $"Mail:" +
                   $"\nDA: {DA}" +
                   $"\nA: {A}" +
                   (!string.IsNullOrEmpty (CC) ? $"\nCC: {CC}" : "") +      // (!string.IsNullOrEmpty(variabile) ? $"{variabile}" : "")  --> da utilizzare per non stampare valori non dichiarati
                   (!string.IsNullOrEmpty (BCC) ? $"\nBCC: {BCC}" : "")+
                   $"\nOggetto: {Oggetto}" +
                   $"\nMessaggio: {Messaggio}" +
                   $"\nData: {Data}" +
                   $"\nPriorità: {Priorita}" +
                   "\n";

        }

    }
}
