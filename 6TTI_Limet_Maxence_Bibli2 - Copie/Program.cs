using _6TTI_Limet_Maxence_Bibli.classe;
using System.Collections.Generic;
using System.ComponentModel;

namespace _6TTI_Limet_Maxence_Bibli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            string recommencer = "";
            Bibliotheque biblio = new Bibliotheque();
            Livre livre = new Livre("","",0);

            string choixC = "";


            do
            {
                Console.WriteLine("Bonjour et bienvenu dans notre bibliothèque. \n Que voulez vous faire ?");
                Console.WriteLine("C : Créer un Livre \n" + 
                                  "D : Dégrader un livre \n" + 
                                  "A : Abonner vous \n" +
                                  "I : Inventaire \n" +
                                  "E : Emprunter un Livre" +
                                  "S : Supprimer les livre trop abîmer");
                ConsoleKeyInfo info = Console.ReadKey(true);
                if (info.Key == ConsoleKey.C)
                {
                    string titre = "";
                    string auteur = "";
                    int etat = 5;
                    Console.WriteLine("Quel titre aimeriez-vous donner à votre livre");
                    titre = Console.ReadLine();
                    Console.WriteLine("Veuillez donner votre nom pour votre livre");
                    auteur = Console.ReadLine();
                    livre = new Livre(titre, auteur, etat);
                    biblio.Ajoute(livre);
                }

                if(info.Key == ConsoleKey.D)
                {
                    livre.Degrade();
                    Console.WriteLine("Dégradation du Livre réussis");
                }

                if(info.Key == ConsoleKey.A)
                {
                    string nom = "";
                    string prenom = "";
                    string email = "";
                    Console.WriteLine("Quel est votre nom ?");
                    nom = Console.ReadLine();
                    Console.WriteLine("Quel est votre prénom ?");
                    prenom = Console.ReadLine();
                    Console.WriteLine("Entrer votre adresse mail");
                    email = Console.ReadLine();
                    biblio.CreeAbonne(nom, prenom, email);
                }
                
                if (info.Key == ConsoleKey.I)
                {
                    Console.WriteLine(biblio.inventaire());
                }

                if (info.Key == ConsoleKey.E)
                {
                    string titre = "";
                    Console.WriteLine("Choisisser un livre à emprunter")
                    titre = Console.ReadLine();
                    if (TrouveLivre(titre, biblio, out livre))
                    biblio.AjouteEmpruntLivre(livre, );
                }

                if (info.Key == ConsoleKey.S)
                {

                }

                Console.WriteLine("Voulez-vous réemprunter un livre");
                recommencer = Console.ReadLine();
            } while (recommencer != "non");
            
        }
        static bool TrouveLivre(string titre, List<Livre> biblio, out Livre livre)
        {
            bool trouve = false;
            livre = null;
            foreach (Livre item in biblio)
            {
                if(item.Titre == titre)
                {
                    livre = item;
                    trouve = true;
                }
            }
            return trouve;
        }
    }
}
