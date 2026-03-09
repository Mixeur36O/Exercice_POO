using _6TTI_Limet_Maxence_Ex3_Entreprise.classe;

namespace _6TTI_Limet_Maxence_Ex3_Entreprise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string recommencer = "non";
            Employe[] employes = new Employe[10];
            employes[0] = new Ouvrier(DateTime.Parse("30/04/2000"), "EMP-4456-ZA", "Boucher", "Pedro", DateTime.Parse("18/05/1985"));
            employes[1] = new Ouvrier(DateTime.Parse("03/02/2025"), "7721-OP-22", "Kennedy", "Leon", DateTime.Parse("18/05/2000"));
            employes[2] = new Ouvrier(DateTime.Parse("12/12/2008"), "LOG-6674-Q", "Bros", "Mario", DateTime.Parse("18/05/1990"));
            employes[3] = new Ouvrier(DateTime.Parse("30/04/1993"), "ADM-1050-Y", "Poud", "Manon", DateTime.Parse("18/05/1974"));
            employes[4] = new Ouvrier(DateTime.Parse("30/04/2015"), "SEC-8812-XX", "Serza", "Erza", DateTime.Parse("18/05/1986"));
            employes[5] = new Cadre(2, "A78-B99C1", "Paolo", "Victor", DateTime.Parse("18/05/1986"));
            employes[6] = new Cadre(4, "2025-00345", "Kom", "Laura", DateTime.Parse("18/05/1986"));
            employes[7] = new Cadre(1, "DX-5501-KL", "Scar", "Nick", DateTime.Parse("18/05/1986"));
            employes[8] = new Directeur(15.9, 50000, "RH-99432-A", "Mondo", "Tomi", DateTime.Parse("18/05/1986"));
            employes[9] = new Directeur(20, 50000, "EMP-2024-8712", "Zerta", "Valerie", DateTime.Parse("18/05/1986"));
            Console.WriteLine("Bonjour et bienvenu dans ce programme de création d'entreprise");
            Console.WriteLine("Nous allons calculer le salaire de tt le monde");
            Console.WriteLine("Appuyer sur O pour voir les ouvriers \n" +
                              "Appuyer sur C pour voir les cadres \n" +
                              "Appuyer sur D pour voir les directeurs \n");
            ConsoleKeyInfo info = Console.ReadKey(true);
            for (int iOS = 0; iOS < 10; iOS++)
            {
                employes[iOS].CalculSalaire();
            }
            if (info.Key == ConsoleKey.O)
            {
                for (int iO = 0; iO < 5; iO++)
                {
                    Console.WriteLine(employes[iO].AfficheCara());
                }
            }
            else if (info.Key == ConsoleKey.C)
            {
                Console.WriteLine(employes[5].AfficheCara());
                Console.WriteLine(employes[6].AfficheCara());
                Console.WriteLine(employes[7].AfficheCara());
            }
            else if (info.Key == ConsoleKey.D)
            {
                Console.WriteLine(employes[8].AfficheCara());
                Console.WriteLine(employes[9].AfficheCara());
            }









        }
    }
}
