using static System.Net.Mime.MediaTypeNames;
using System.Runtime.Intrinsics.Arm;
using System.Text.RegularExpressions;

namespace ClasseHardDisk
{
    internal class Program
    {
        static void Main(string[] args)
        {
 /*
Si vogliono confrontare 5 diversi modelli di hard disk.Ognuno è caratterizzato dalla marca, dalla velocità(espressa in RTM, rotazioni per minuto), 
dal tempo di accesso(espresso in millisecondi) e dalla capacità(espressa in gigabyte).

Ad ogni modello viene assegnato un punteggio nel seguente modo:

per la velocità viene assegnato 1 punto ogni giro al minuto
per il tempo di accesso vengono assegnati -200 punti al millisecondo(più alto è il tempo, più basso è il punteggio)
per la capacità vengono assegnati 500 punti ogni gigabyte
Creare una classe test per istanziare i 5 modelli richiesti.
 */

            HDD hd1 = new HDD("Marca1",1000, 10, 256);
            Console.WriteLine(hd1.ToString());

            HDD hd2 = new HDD("Marca2", 1200, 10, 128);
            Console.WriteLine(hd2.ToString());

            HDD hd3 = new HDD("Marca3", 600, 10, 100);
            Console.WriteLine(hd3.ToString());

            HDD hd4 = new HDD("Marca4", 500, 10, 1000);
            Console.WriteLine(hd4.ToString());

            HDD hd5 = new HDD("Marca5", 2000, 10, 256);
            Console.WriteLine(hd5.ToString());
        }
    }
}
