namespace Matrici
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matrici!");
            //dichiarazione di una matrice
            int[,] matrice = new int[2, 3]; //2 righe x 3 colonne
            //riempimento prima riga
            matrice[0, 0] = 12;
            matrice[0, 1] = 12;
            matrice[0, 2] = 12;
            //riempimento seconda riga
            matrice[1, 0] = 12;
            matrice[1, 1] = 12;
            matrice[1, 2] = 12;

            //Console.WriteLine($"[1,1]: {matrice[1, 1]}");

            for ( int i = 0;i<2;i++ )
            {
                for (int j = 0; j < 3; j++)
                    Console.Write($"{matrice[1, 1]} ");
                    Console.WriteLine();
            }

        }
    }
}
