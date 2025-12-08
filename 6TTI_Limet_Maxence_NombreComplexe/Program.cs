using _6TTI_Limet_Maxence_NombreComplexe.classe;

namespace _6TTI_Limet_Maxence_NombreComplexe
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string recommencer = "non";
            do
            {
                //Variable
                string nbrUti1 = "";
                string nbrUti2 = "";
                int val1 = 0;
                int val2 = 0;
                Console.WriteLine("Bienvenu dans ce programme sur les complexes !");
                Console.WriteLine("Que vaut la partie réelle du complexe de départ ?");
                nbrUti1 = Console.ReadLine();
                NombreUti(nbrUti1, out val1);
                Console.WriteLine("Que vaut la partie imaginaire du complexe de départ ?");
                nbrUti2 = Console.ReadLine();
                NombreUti(nbrUti2, out val2);
                Complexe complexe = new Complexe(val1, val2);
                Console.WriteLine(complexe.CalculeModule());
                Console.WriteLine("Encodez un second nombre complexe");
                Console.WriteLine("Que vaut la partie réelle du second complexe ?");
                nbrUti1 = Console.ReadLine();
                NombreUti(nbrUti1, out val1);
                Console.WriteLine("Que vaut la partie imaginaire du second complexe ?");
                nbrUti2 = Console.ReadLine();
                NombreUti(nbrUti2, out val2);
                complexe.Reel = val1;
                complexe.Imaginaire = val2;
                Console.WriteLine(complexe.AfficheComplexe());
                Console.WriteLine(complexe.Ajoute() + "\n");
                Console.WriteLine("Voulez-vous recommencer (si non tapez non)");
                recommencer = Console.ReadLine();
            } while (recommencer != "non");
            

        }
        static void NombreUti(string nbrUti, out int val)
        {
            if (!int.TryParse(nbrUti, out val))
            {
                Console.WriteLine("Ceci n'est pas un nombre");
                Console.WriteLine("Tapez un rayon pour votre cercle");
                nbrUti = Console.ReadLine();
            }

        }
    }
}
