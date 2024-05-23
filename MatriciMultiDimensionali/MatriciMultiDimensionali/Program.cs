namespace MatriciMultiDimensionali
{
    /*
     * Generare casualmente una matrice multidimensionale di numeri interi appartenenti all'intervallo [-100, 100]
     * 
     * numero di righe -> casuale [1,10]
     * Numero di colonne -> casuale [1,20]
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            // numeri
            Random random = new Random();
            int righe = random.Next(0, 10) + 1;

            // dic di una matrice multi dimens.
            int[][] matrice =new int[righe][];

            // riempimento della matrice
            for (int i = 0; i < righe; i++)
            {
                int colonne = random.Next(0, 20) + 1;
                matrice[i] = new int[colonne];
                for (int j = 0; j < colonne; j++)
                    matrice[i][j] = random.Next(-100, 101);
            }
            for 
            }
    }
}
