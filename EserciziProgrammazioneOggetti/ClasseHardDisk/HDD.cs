using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseHardDisk
{
    internal class HDD
    {
    public string Marca {  get; set; }
    public int Velocita { get; set; }
    public int AccTemp {  get; set; }
    public int Capacita { get; set; }

        public HDD(string marca, int velocita, int accTemp, int capacita)
        {
            Marca = marca;
            Velocita = velocita;
            AccTemp = accTemp;
            Capacita = capacita;
        }

        public int PuntAccesso()
        {
            return AccTemp * 200;
        }

        public int PuntCap()
        {
            return Capacita*500;
        }

        public int PuntVelocita()
        {
            return Velocita
                ;
        }

        public int TotPunti()
        {
            return PuntVelocita() + PuntCap() - PuntAccesso();
        }

        public override string ToString()
        {
            return $"Marca: {Marca}" +
                   $"\nVelocità: {Velocita} RTM - Punteggio: {Velocita}" +
                   $"\nVelocità di accesso: {AccTemp} ms - Punteggio -{PuntAccesso()}" +
                   $"\nCapacità: {Capacita} GB - Punteggio: {PuntCap()}" +
                   $"\nPunteggio Totale: {TotPunti()}" +
                   "\n";
        }
    }
}
