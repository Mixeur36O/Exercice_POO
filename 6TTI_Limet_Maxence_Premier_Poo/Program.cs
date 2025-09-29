namespace _6TTI_Limet_Maxence_Premier_Poo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chien[] mesChiens = new Chien[3];
            string aliments;
            mesChiens[0] = new Chien("Marcus", 4, "Korgui");
            mesChiens[1] = new Chien("Paul", 5, "Bouldog");
            mesChiens[2] = new Chien("Guillaume", 1, "saucisse");

            for (int i = 0; i < mesChiens.Length; i++)
            {
                Console.WriteLine(mesChiens[i].Affichercaracteristique());
                Console.WriteLine(mesChiens[i].Aboyer());
                mesChiens[i].Aliment(out aliments);
                Console.WriteLine(mesChiens[i].Manger(aliments));
                mesChiens[i].veillir();
                Console.WriteLine(mesChiens[i].Affichercaracteristique());
            }
        }

    }
}
