using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_Limet_Maxence_Ex4_Herit_Vehi.classe
{
    internal class Car : RoadVehicule
    {
        //Attributs

        //Props

        //Construct
        public Car(double fuel, string brand, double km) : base(fuel, brand, km)
        {

        }

        //Méthodes
        public override string AfficheCar()
        {
            string info = $"Votre voiture vient de la marque {Brand}. \n" +
                $"Sa jauge de fuel est de {Fuel}, elle peut aller jusqu'à {Km}km";
            return info;
        }
    }
}
