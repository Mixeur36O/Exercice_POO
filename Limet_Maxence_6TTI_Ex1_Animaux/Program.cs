using Limet_Maxence_6TTI_Ex1_Animaux.Classe;

namespace Limet_Maxence_6TTI_Ex1_Animaux
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable
            Animal[] animal = new Animal[5];
            animal[0] = new Chien("Bouboul",DateTime.Parse("12/03/2025"), 32547, 54.4, false);
            animal[1] = new Chien("Doug", DateTime.Parse("25/08/2020"), 38897, 25.6, true);
            animal[2] = new Chat("Mistigris", DateTime.Parse("07/07/2024"), 66234, 30, true);
            animal[3] = new Chat("Zabou", DateTime.Parse("03/02/2026"), 10340, 46.8, false);
            animal[4] = new Lapin("Carrot", DateTime.Parse("02/12/2022"), 75432, 25.7, true, 16.7);

            for (int iAnimal = 0; iAnimal < animal.Length; iAnimal++ )
            {
                
                if (animal[iAnimal] is Chien chien)
                {
                    Console.WriteLine(animal[iAnimal].Information() + "\n");
                    Console.WriteLine(chien.Aboyer() + "\n");
                }
                else if(animal[iAnimal] is Chat chat)
                {
                    Console.WriteLine(animal[iAnimal].Information() + "\n");
                    Console.WriteLine(chat.Ronronner() + "\n");
                    Console.WriteLine(chat.Miauler() + "\n");
                }
                else if (animal[iAnimal] is Lapin lapin)
                {
                    Console.WriteLine(lapin.Bondir());
                    Console.WriteLine(lapin.Information() + "\n");

                }
                Console.WriteLine(animal[iAnimal].Manger() + "\n");
                Console.WriteLine("Maintenat " + animal[iAnimal].Dormir() + "\n");
            }
        }
    }
}
