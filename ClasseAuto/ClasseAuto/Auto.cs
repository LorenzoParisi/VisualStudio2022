using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClasseAuto
{
    internal class Auto
    {
        int scegli;
        public Auto(string marca, string modello, double cilindrata, Alimentazione alimentazione, string colore, double velocitaBase)
        {
            Marca = marca;
            Modello = modello;
            Cilindrata = cilindrata;
            Alimentazione = alimentazione;
            Colore = colore;
            VelocitaBase = velocitaBase;
            //VelMax = velMax;
        }

        public string Marca {  get; set; }

        public string Modello { get; set; }

        public double Cilindrata { get; set; }

        public Alimentazione Alimentazione { get; set; }

        public string Colore { get; set; }

        public double VelocitaBase { get; set; }

       public double VelocitaAttuale(double velocitaBase)
        {
            switch (scegli)
            {
                case 1: VelocitaBase=velocitaBase+10; return velocitaBase += 10; break;
                case 2: VelocitaBase = velocitaBase + 10; return velocitaBase -= 5; break;
           //   case 0: 
                default: VelocitaBase = velocitaBase + 10; return velocitaBase+= 0;
            }
            
            
        }
         
        

       public int VelMax { get; set; }

      public double VelocitaMax()
        {
            int bonus = 0;
        switch (Alimentazione)
            {
                case Alimentazione.Benzina: return VelMax += 30; break;
                case Alimentazione.Diesel: return VelMax += 20; break;
                case Alimentazione.Gpl : return VelMax -= 10; break;
                case Alimentazione.Metano : return VelMax -= 30; break;
            }
            return VelMax+bonus;
        }

/*        public override string ToString()
        {
            return $"" +
            $"Marca: {Marca}" +
            $" Modello: {Modello}" +
            $" Cilindrata: {Cilindrata}" +
            $" Alimentazione: {Alimentazione}" +
            $" Colore: {Colore}";
           //$"Velocita Max: {VelocitaMax()}";
        } 
*/
          public override string ToString()
        {
            return $"Il suo veicolo {Marca} {Modello} sta viaggiando alla velocità di {VelocitaAttuale(VelocitaBase)} km/h";
        }
    }
}