namespace Azienda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
Si consideri una azienda che si occupa di impianti di estrazione di petrolio negli oceani in cui lavorano diverse tipologie di dipendente. 
Di un dipendente si conoscono le seguenti informazioni: cognome, nome, paga oraria, numero di ore lavorate e si può determinare 
lo stipendio percepito semplicemente calcolando il numero delle ore per la paga oraria.

I dipendenti si dividono in amministrativi e operai. 

Per gli amministrativi concorre alla definizione dello stipendio la mansione svolta. Le mansioni sono: contabile, risorse umane e direttore. 
Gli introiti aggiuntivi allo stipendio degli amministrativi sono: 

contabile - 150 euro

risorse umane - 75 euro

direttore - 250 euro

Gli operai sono suddivisi in installatori e manutentori. Per gli installatori è previsto un bonus di 185,00 euro aggiuntivi allo stipendio, mentre per i manutentori la cifra corrisposta è 230,00 euro

Tra gli operai ci sono gli operai specializzati che effettuano missioni sulle piattaforme oceaniche e a cui corrisponde una indennità. 
Le missioni e relative indennità concorrono alla definizione dello stipendio.

Creare un elenco di dipendenti, suddivisi tra amministrativi, operai e operai specializzati.

Visualizzare l'elenco dei dipendenti con tutti i loro dati
             */

            Amministrativo a1 = new Amministrativo(MansioneAmministrativo.CONTABILE, "Virgilio", "Memmo", 10, 85);
            //Console.WriteLine(a1);
            Amministrativo a2 = new Amministrativo(MansioneAmministrativo.RISORSEUMANE, "Marco", "Cartone", 8, 97);
            //Console.WriteLine(a2); 
            Amministrativo a3 = new Amministrativo(MansioneAmministrativo.DIRETTORE, "Luigi", "Maligno", 9, 112);
            //Console.WriteLine(a3);

            Operaio o1 = new Operaio(MansioneOperaio.MANUTENTORE, "Ajeje", "Brazorf", 12, 100, 5);
            //Console.WriteLine(o1);
            Operaio o2 = new Operaio(MansioneOperaio.INSTALLATORE, "Franco", "Filone", 11, 120, 10);
            //Console.WriteLine(o2);

            Dipendente[] dipendenti = {a1, a2, a3, o1,o2};

            Console.WriteLine("Operai:");
            foreach(Dipendente dipendente in dipendenti)
                if(dipendente is Operaio)
                    Console.WriteLine(dipendente);

            Console.WriteLine("Amministrativi:");
            foreach (Dipendente dipendente in dipendenti)
                if (dipendente is Amministrativo)
                    Console.WriteLine(dipendente);


        }
    }
}
