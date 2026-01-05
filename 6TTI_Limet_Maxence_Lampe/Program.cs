using _6TTI_Limet_Maxence_Lampe.classe;

namespace _6TTI_Limet_Maxence_Lampe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string recommence = "non";
            Lampe lampe = new Lampe("Blanche", "Pied");
            Interrupteur interrupteur = new Interrupteur(false);
            do
            {
                string repUser = ""; 
                Console.WriteLine("Voulez-vous voir les caractéristiques de votre lampe");
                repUser = Console.ReadLine();
                //Variables
                if (repUser == "oui")
                {
                    Console.WriteLine(lampe.CaractéristiqueL());
                }
                Console.WriteLine("Bonjour voulez-vous allumer la lampe");
                repUser = Console.ReadLine();
                if (repUser == "oui")
                {
                    interrupteur.Allumage = true;
                    Console.WriteLine(interrupteur.AllumageL());
                }
                else
                {
                    interrupteur.Allumage = false;
                    Console.WriteLine(interrupteur.AllumageL());
                }
                Console.WriteLine("Voulez-vous altérer l'état de votre lampe");
                recommence = Console.ReadLine();
            } while (recommence != "non");
        }
    }
}
