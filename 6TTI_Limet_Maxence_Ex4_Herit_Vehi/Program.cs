using _6TTI_Limet_Maxence_Ex4_Herit_Vehi.classe;

namespace _6TTI_Limet_Maxence_Ex4_Herit_Vehi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string recommencer = "non";
            do
            {
                Console.WriteLine("Bonjour et bienvenu, veuillez entrer votre véhicule");
                Console.WriteLine("Appuyer sur V pour la voiture \n" +
                      "Appuyer sur A pour l'avion \n" +
                      "Appuyer sur B pour le bateau \n" +
                      "Appuyer sur T pour le truck \n");
                ConsoleKeyInfo info = Console.ReadKey(true);
                if (info.Key == ConsoleKey.V)
                {
                    string marque = "";
                    string kmU = "";
                    string fuelU = "";
                    double valF = 0;
                    double valK = 0;
                    Console.WriteLine("Vous avez choisi la voiture");
                    Console.WriteLine("Veuillez entrer la marque de votre véhicule");
                    marque = Console.ReadLine();
                    Console.WriteLine("Veuillez entrer le niveu de fuel");
                    while (!double.TryParse(fuelU, out valF))
                    {
                        Console.WriteLine("Ce n'est pas un nombre");
                        Console.WriteLine("Choisissez un nombre pour votre fuel");
                        fuelU = Console.ReadLine();
                    }
                    Console.WriteLine("Veuillez entrer le nombre de km");
                    while (!double.TryParse(kmU, out valK))
                    {
                        Console.WriteLine("Ce n'est pas un nombre");
                        Console.WriteLine("Choisissez un nombre pour vos km");
                        fuelU = Console.ReadLine();
                    }
                    Console.WriteLine("Création de votre véhicule.\n");
                    Car car = new Car(valF, marque, valK);
                    Console.WriteLine("Et voilà les caractéristiques de votre véhicule. \n");
                    Console.WriteLine(car.AfficheCar());
                }
                else if (info.Key == ConsoleKey.A)
                {
                    string marque = "";
                    string rangeU = "";
                    string fuelU = "";
                    double valF = 0;
                    double valR = 0;
                    Console.WriteLine("Vous avez choisi l'avion");
                    Console.WriteLine("Veuillez entrer la marque de votre véhicule");
                    marque = Console.ReadLine();
                    Console.WriteLine("Veuillez entrer le niveu de fuel");
                    while (!double.TryParse(fuelU, out valF))
                    {
                        Console.WriteLine("Ce n'est pas un nombre");
                        Console.WriteLine("Choisissez un nombre pour votre fuel");
                        fuelU = Console.ReadLine();
                    }
                    Console.WriteLine("Veuillez entrer le nombre de votre range");
                    while (!double.TryParse(rangeU, out valR))
                    {
                        Console.WriteLine("Ce n'est pas un nombre");
                        Console.WriteLine("Choisissez un nombre pour votre range");
                        fuelU = Console.ReadLine();
                    }
                    Console.WriteLine("Création de votre véhicule.\n");
                    Plane avion = new Plane(valF, marque, valR);
                    Console.WriteLine("Et voilà les caractéristiques de votre véhicule. \n");
                    Console.WriteLine(avion.AfficheCar());
                }
                else if (info.Key == ConsoleKey.B)
                {
                    string marque = "";
                    string tonnageU = "";
                    string fuelU = "";
                    double valF = 0;
                    double valT = 0;
                    Console.WriteLine("Vous avez choisi le bateau");
                    Console.WriteLine("Veuillez entrer la marque de votre véhicule");
                    marque = Console.ReadLine();
                    Console.WriteLine("Veuillez entrer le niveu de fuel");
                    while (!double.TryParse(fuelU, out valF))
                    {
                        Console.WriteLine("Ce n'est pas un nombre");
                        Console.WriteLine("Choisissez un nombre pour votre fuel");
                        fuelU = Console.ReadLine();
                    }
                    Console.WriteLine("Veuillez entrer le nombre de votre tonnage");
                    while (!double.TryParse(tonnageU, out valT))
                    {
                        Console.WriteLine("Ce n'est pas un nombre");
                        Console.WriteLine("Choisissez un nombre pour votre tonnage");
                        fuelU = Console.ReadLine();
                    }
                    Console.WriteLine("Création de votre véhicule.\n");
                    Boat boat = new Boat(valF, marque, valT);
                    Console.WriteLine("Et voilà les caractéristiques de votre véhicule. \n");
                    Console.WriteLine(boat.AfficheCar());
                }
                else if (info.Key == ConsoleKey.T)
                {
                    string marque = "";
                    string kmU = "";
                    string fuelU = "";
                    string weightU = "";
                    double valF = 0;
                    double valK = 0;
                    double valW = 0;
                    Console.WriteLine("Vous avez choisi le truck");
                    Console.WriteLine("Veuillez entrer la marque de votre véhicule");
                    marque = Console.ReadLine();
                    Console.WriteLine("Veuillez entrer le niveu de fuel");
                    while (!double.TryParse(fuelU, out valF))
                    {
                        Console.WriteLine("Ce n'est pas un nombre");
                        Console.WriteLine("Choisissez un nombre pour votre fuel");
                        fuelU = Console.ReadLine();
                    }
                    Console.WriteLine("Veuillez entrer le nombre de km");
                    while (!double.TryParse(kmU, out valK))
                    {
                        Console.WriteLine("Ce n'est pas un nombre");
                        Console.WriteLine("Choisissez un nombre pour vos km");
                        fuelU = Console.ReadLine();
                    }
                    Console.WriteLine("Veuillez entrer le poid");
                    while (!double.TryParse(weightU, out valW))
                    {
                        Console.WriteLine("Ce n'est pas un nombre");
                        Console.WriteLine("Choisissez un nombre pour votre poids");
                        fuelU = Console.ReadLine();
                    }
                    Console.WriteLine("Création de votre véhicule.\n");
                    Truck truck = new Truck(valF, marque, valK, valW);
                    Console.WriteLine("Et voilà les caractéristiques de votre véhicule. \n");
                    Console.WriteLine(truck.AfficheCar());
                }
            } while (recommencer != "non");
        }
    }
}
