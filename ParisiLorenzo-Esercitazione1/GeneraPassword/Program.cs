using System.Runtime.InteropServices;

namespace GeneraPassword
{
    internal class Program
    //   Mobile App Developer, Fondamenti di programmazione, Parisi, Lorenzo, 15 aprile 2024
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserire lunghezza password (minimo 8 caratteri):");
            int n= int.Parse(Console.ReadLine());

            //se la lunghezza è inferiore non è possibile procedere
            if (n < 8)
                {
                    Console.WriteLine("Riprovare! Chiudere il programma e inserire un valore superiore o uguale a 8.");
                } else
                {

            //se la lunghezza è superiore o uguale a 8 è possibile procedere

            //array
            int[] password = new int[n];
            Random random = new Random();

            //Stampa della password (
            Console.WriteLine("Ecco la password generata:");
            for(int i = 0; i < password.Length; i++)
            {
                    password[i] = random.Next(n);                    
                }
            } 
        }
    }
}
