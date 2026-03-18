using _6TTI_Limet_Maxence_Bibli.classe;
using Google.Protobuf.WellKnownTypes;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;

namespace _6TTI_Limet_Maxence_Bibli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            Abonne emprunteur;

            string recommencer = "";
            Bibliotheque biblio = new Bibliotheque();
            Livre livre = new Livre(0,"","","",0,0);
            MesDonnees donnee = new MesDonnees();
            DataSet donneeL = new DataSet();

            string choixC = "";
            do
            {
                Console.WriteLine("Bonjour et bienvenu dans notre bibliothèque. \n Que voulez vous faire ?");
                Console.WriteLine("C : Créer un Livre \n" + 
                                  "D : Dégrader un livre \n" + 
                                  "A : Abonner vous \n" +
                                  "I : Inventaire \n" +
                                  "E : Emprunter un Livre \n" +
                                  "S : Supprimer les livre trop abîmer \n" +
                                  "L : Pour afficher la liste des livre empruntés");
                ConsoleKeyInfo info = Console.ReadKey(true);
                if (info.Key == ConsoleKey.C)
                {
                    string titreU = "";
                    string nomU = "";
                    string prenomU = "";
                    string anneeU = "";
                    int etat = 5;
                    int valA = 0;
                    Console.WriteLine("Veuillez donner votre nom pour votre livre");
                    nomU = Console.ReadLine();
                    Console.WriteLine("Veuillez donner votre prénom pour votre livre");
                    prenomU = Console.ReadLine();
                    Console.WriteLine("Quel titre aimeriez-vous donner à votre livre");
                    titreU = Console.ReadLine();
                    DonneeUti(anneeU , out valA);
                    biblio.Ajoute(nomU, prenomU, titreU, valA, etat);
                    //if (!donnee.TrouveUnLivre(titreU, out livreExistant, donneeL))
                    //{
                    //    
                    //}
                    //else
                    //{
                    //    Console.WriteLine("Votre livre existe déjà");
                    //}
                    
                }
                if(info.Key == ConsoleKey.D)
                {
                    string entreeU = "";
                    int val = 0;
                    DonneeUti(entreeU, out val);
                    livre.Degrade(val);
                    Console.WriteLine("Dégradation du Livre réussis");
                }

                if(info.Key == ConsoleKey.A)
                {
                    string nomU = "";
                    string prenomU = "";
                    string emailU = "";
                    string loginU = "";
                    string mdpU = "";
                    Console.WriteLine("Quel est votre nom ?");
                    nomU = Console.ReadLine();
                    Console.WriteLine("Quel est votre prénom ?");
                    prenomU = Console.ReadLine();
                    Console.WriteLine("Entrer votre adresse mail");
                    emailU = Console.ReadLine();
                    Console.WriteLine("Entrer un login");
                    loginU = Console.ReadLine();
                    Console.WriteLine("Entrer un mot de passe");
                    mdpU = Console.ReadLine();
                    biblio.CreeAbonne(nomU, prenomU, emailU, loginU, mdpU);
                }
                
                if (info.Key == ConsoleKey.I)
                {
                    Console.WriteLine(biblio.inventaire());
                }

                if (info.Key == ConsoleKey.E)
                {
                    string titre = "";
                    Console.WriteLine("Choisisser un livre à emprunter");
                    titre = Console.ReadLine();
                    if (TrouveLivre(titre, biblio.Livres, out livre))
                    {
                        string nom = "";
                        Console.WriteLine("Donner-moi votre nom d'abonne");
                        nom = Console.ReadLine();
                        if (TrouveEmprunteur(nom, biblio.Abonnes, out emprunteur))
                        {
                            biblio.AjouteEmpruntLivre(livre, emprunteur, DateTime.Today);
                        }
                    }
                }

                if (info.Key == ConsoleKey.S)
                {
                    biblio.supprime_livres_abimes();
                    Console.WriteLine("La suppression des livres abîmés à bien été réussis");
                }

                if (info.Key == ConsoleKey.L)
                {
                    Console.WriteLine(biblio.ListeLivresEmprunts());
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
                else
                {
                    Console.WriteLine("Vos livre ne se trouve pas en bibliothèque");
                }
            }
            return trouve;
        }

        static bool TrouveEmprunteur(string nom, List<Abonne> biblio, out Abonne emprunteur)
        {
            bool trouve = false;
            emprunteur = null;
            foreach(Abonne item in biblio)
            {
                if (item.Nom == nom)
                {
                    emprunteur = item;
                    trouve = true;
                }
                else
                {
                    Console.WriteLine("Désoler vous n'êtes pas abonner");
                }
            }
            return trouve;
            
        }

        static void DonneeUti(string entreeU, out int val )
        {
            val = 0;
            Console.WriteLine("En quelle année est-il parru ?");
            entreeU = Console.ReadLine();
            while (!int.TryParse(entreeU, out val))
            {
                Console.WriteLine("Ce nest pas une année conforme");
                Console.WriteLine("En quelle année est-il parru ?");
                entreeU = Console.ReadLine();
            }
        }
    }
}
