using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_Limet_Maxence_Ex4_Herit_Vehi.classe
{
    internal class Plane : Vehicule
    {
        //Attributs
        private double _range;

        //Props
        public double Range
        {
            get { return _range; }
            set { _range = value; }
        }

        //Construct
        public Plane(double fuel, string brand, double range) : base(fuel, brand)
        {
            _range = range;
        }

        //Méthodes
        public override string AfficheCar()
        {
            string info = $"Votre avion vient de la marque {Brand}. \n" +
                $"Sa jauge de fuel est de {Fuel} et son tonnage est de {_range}";
            return info;

        }
    }
}
