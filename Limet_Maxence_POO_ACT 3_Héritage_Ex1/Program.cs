using Limet_Maxence_POO_ACT_3_Héritage_Ex1.Classe;

namespace Limet_Maxence_POO_ACT_3_Héritage_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            Vheicule[] vehicule = new Vheicule[4];

            vehicule[0] = new Velo("VTT", "Decathlon", "noir", 120, "VTT", false);
            vehicule[1] = new Vheicule("Clio", "peugot", "gris", 2000);
            vehicule[2] = new Voiture("lamborguini", "ferrari", "mauve", 10000, "Diesel", true);
            vehicule[3] = new Vheicule("4X4", "Volsuaguen", "noir", 20000);

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(vehicule[i].Affiche());
            }

        }
    }
}
