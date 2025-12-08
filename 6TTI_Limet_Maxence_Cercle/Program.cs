using _6TTI_Limet_Maxence_Cercle.Classe;

namespace _6TTI_Limet_Maxence_Cercle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string recommencer = "non";
            do
            {
                //Variable
                string nbrUti = "";
                int val = 0;
                Console.WriteLine("Bienvenue dans ce programme sur le cercle !");
                Console.WriteLine("Tapez un rayon pour votre cercle");
                nbrUti = Console.ReadLine();
                NombreUti(nbrUti, out val);
                cercle cercleUti = new cercle(val);
                Console.WriteLine(cercleUti.CalculerPerimetreAir());
                Console.WriteLine("Avec un cercle de rayon diminué de moitié :");
                Console.WriteLine("-------------------------------");
                Console.WriteLine(cercleUti.CalculerPerimetreAir2());
                Console.WriteLine("Vouler vous recommencer ?");
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
