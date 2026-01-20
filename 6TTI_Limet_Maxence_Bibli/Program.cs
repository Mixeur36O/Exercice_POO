using _6TTI_Limet_Maxence_Bibli.classe;
using System.ComponentModel;

namespace _6TTI_Limet_Maxence_Bibli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            string recommencer = "";
            Livre[] livre = new Livre[5];
            Bibliotheque biblio = new Bibliotheque();
            livre[0] = new Livre("Dans ton regard", "Micheall Don", 3);
            livre[1] = new Livre("Dernier jour d'un condamné", "Victor Hugo", 4);
            livre[2] = new Livre("Mickey Mouse", "Disney", 2);
            livre[3] = new Livre("Spirou", "Rob-Vel", 1);
            livre[4] = new Livre("Naruto 23", "Masachi Kishimoto", 5);
            
            string choixC = "";

            //Ajouter à la bibliothèque
            for (int iBiblio = 0; iBiblio < livre.Length; iBiblio++)
            {
                biblio.Ajoute(livre[iBiblio]);
            }
            do
            {
                Console.WriteLine("Bonjour et bienvenu dans notre bibliothèque");
                Console.WriteLine("Je vais vous montrez le choix que vous avez");
                Console.WriteLine(biblio.inventaire());
                Console.WriteLine("Quel livre désiriez-vous emprinter (choisisser entre 1 et 5)");
                choixC = Console.ReadLine();

                switch (choixC)
                {
                    case "1":
                        Console.WriteLine(livre[0].Description());
                        break;
                    case "2":
                        Console.WriteLine(livre[1].Description());
                        break;
                    case "3":
                        Console.WriteLine(livre[2].Description());
                        break;
                    case "4":
                        Console.WriteLine(livre[3].Description());
                        break;
                    case "5":
                        Console.WriteLine(livre[4].Description());
                        break;
                }
                Console.WriteLine("Voulez-vous réemprunter un livre");
                recommencer = Console.ReadLine();
            } while (recommencer != "non");
            
        }
    }
}
