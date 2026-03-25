using _6TTI_Limet_Maxence_Bibli.classe;
using Google.Protobuf.WellKnownTypes;
using Mysqlx;
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
            MethodeProgramme mdtPro = new MethodeProgramme();

            string choixC = "";
            do
            {
                Console.WriteLine("Bonjour et bienvenu dans notre bibliothèque. \n Que voulez vous faire ?");
                Console.WriteLine("C : Créer un Livre \n" + 
                                  "D : Dégrader un livre \n" + 
                                  "A : Abonner vous \n" +
                                  "I : Inventaire \n" +
                                  "L : Liste des abonnés \n" +
                                  "E : Emprunter un Livre \n" +
                                  "S : Supprimer les livre trop abîmer \n" +
                                  "P : Pour afficher la liste des livre empruntés");
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
                    mdtPro.DonneeUti(anneeU , out valA);
                    Livre livreExistant;
                    if (!mdtPro.TrouveUnLivre(titreU, biblio.Livres, out livreExistant))
                    {
                        biblio.Ajoute(nomU, prenomU, titreU, valA, etat);
                    }
                    else
                    {
                        Console.WriteLine("Votre livre existe déjà");
                    }

                }
                if(info.Key == ConsoleKey.D)
                {
                    string entreeU = "";
                    int val = 0;
                    mdtPro.DonneeUti(entreeU, out val);
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
                    Abonne abonneExistant;
                    if (!mdtPro.TrouveUnAbonne(loginU, biblio.Abonnes, out abonneExistant))
                    {
                        biblio.CreeAbonne(nomU, prenomU, emailU, loginU, mdpU);
                    }
                    else
                    {
                        Console.WriteLine("Vous vous êtes déja abonné");
                    }
                }
                
                if (info.Key == ConsoleKey.I)
                {
                    Console.WriteLine(biblio.inventaire());
                }

                if (info.Key == ConsoleKey.L)
                {
                    Console.WriteLine(biblio.ListAbonne());
                }

                if (info.Key == ConsoleKey.E)
                {
                    string idL = "";
                    Console.WriteLine("Nous allons demander l'id de livre que vous voulez emprunter\n");
                    mdtPro.DonneeID(idL, out int valId);
                    if (mdtPro.TrouveLivre(valId, biblio.Livres, out livre))
                    {
                        string idU = "";
                        Console.WriteLine("Nous allons demander votre id d'abonner \n");
                        mdtPro.DonneeID(idU, out int valIdU);
                        if (mdtPro.TrouveEmprunteur(valIdU, biblio.Abonnes, out emprunteur))
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

                if (info.Key == ConsoleKey.P)
                {
                    Console.WriteLine(biblio.ListeLivresEmprunts());
                }

                Console.WriteLine("Voulez-vous réemprunter un livre");
                recommencer = Console.ReadLine();
            } while (recommencer != "non");


            
        }
    }
}
