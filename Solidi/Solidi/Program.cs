namespace Solidi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Esercizio - Solidi

                Si vuole calcolare il peso di un solido costruito con un certo materiale di cui si conosce il peso specifico.

                Si richiede la creazione di una istanza cubo e sfera di alluminio.

                Visualizzare tutti i dati necessari*/

            Dictionary<Materiale, double> materiali = new Dictionary<Materiale, double>();
            materiali.Add(Materiale.ACCIAIO, 7.85);
            materiali.Add(Materiale.ALLUMINIO, 2.60);
            materiali.Add(Materiale.ZINCO, 7.10);
            materiali.Add(Materiale.TUNGSTENO, 19.10);
            materiali.Add(Materiale.STAGNO, 7.28);
            materiali.Add(Materiale.RAME, 8.90);
            materiali.Add(Materiale.PLATINO, 21.45);


            double acciao = 7.85;
            //Solido s = new Solido();
           

            Cubo c = new Cubo(1, materiali[Materiale.ACCIAIO]);
            Console.WriteLine(c);

            Sfera s = new Sfera(1, materiali[Materiale.TUNGSTENO]);
            Console.WriteLine(s);

            Cilindro cil = new Cilindro(10,99, materiali[Materiale.TUNGSTENO]);
            Console.WriteLine(cil);

        }
    }
}
