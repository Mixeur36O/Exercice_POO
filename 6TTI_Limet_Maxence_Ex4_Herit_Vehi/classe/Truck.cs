using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_Limet_Maxence_Ex4_Herit_Vehi.classe
{
    internal class Truck : RoadVehicule
    {
        //Attributs
        private double _weight;

        //Props

        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }


        //Construct
        public Truck(double fuel, string brand, double km, double weight) : base(fuel, brand, km)
        {
            _weight = weight;
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
