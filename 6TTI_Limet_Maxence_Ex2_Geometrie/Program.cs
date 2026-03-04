using _6TTI_Limet_Maxence_Ex2_Geometrie.classe;

namespace _6TTI_Limet_Maxence_Ex2_Geometrie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string recommencer = "non";
            do
            {
                Console.WriteLine("Bonjour et bienvenu dans notre construction géométrique. \n Que voulez vous faire ?");
                Console.WriteLine("C : Créer un Carre \n" +
                                  "R : Créer un Rectangle \n");
                ConsoleKeyInfo info = Console.ReadKey(true);
                if (info.Key == ConsoleKey.C)
                {
                    int val;
                    string coteU = "";
                    string couleurU = "";
                    Console.WriteLine("Choisissez un nombre pour votre côté");
                    coteU = Console.ReadLine();
                    Console.WriteLine("Choisissez la couleur");
                    couleurU = Console.ReadLine();
                    while(!int.TryParse(coteU, out val))
                    {
                        Console.WriteLine("Ce n'est pas un nombre");
                        Console.WriteLine("Choisissez un nombre pour votre côté");
                        coteU = Console.ReadLine();
                    }
                    Carre carre = new Carre(val, couleurU);

                    Console.WriteLine("Nous allons mtn calculer votre surface et votre perimetre");
                    carre.CalculPerimetre();
                    carre.CalculSurface();

                    Console.WriteLine(carre.AfficheInfos());
                }

                if (info.Key == ConsoleKey.R)
                {
                    int valL;
                    int valLa;
                    string longueurU = "";
                    string largeurU = "";
                    string couleurU = "";
                    Console.WriteLine("Choisissez un nombre pour votre longueur");
                    longueurU = Console.ReadLine();
                    Console.WriteLine("Choisissez un nombre pour votre longueur");
                    largeurU = Console.ReadLine();
                    Console.WriteLine("Choisissez la couleur");
                    couleurU = Console.ReadLine();
                    while (!int.TryParse(longueurU, out valL))
                    {
                        Console.WriteLine("Ce n'est pas un nombre");
                        Console.WriteLine("Choisissez un nombre pour votre côté");
                        longueurU = Console.ReadLine();
                    }
                    while (!int.TryParse(largeurU, out valLa))
                    {
                        Console.WriteLine("Ce n'est pas un nombre");
                        Console.WriteLine("Choisissez un nombre pour votre côté");
                        largeurU = Console.ReadLine();
                    }
                    Rectangle rect = new Rectangle(valL, valLa, couleurU);

                    Console.WriteLine("Nous allons mtn calculer votre surface et votre perimetre");
                    rect.CalculPerimetre();
                    rect.CalculSurface();

                    Console.WriteLine(rect.AfficheInfos());
                }
            } while (recommencer != "non");

        }
    }
}
