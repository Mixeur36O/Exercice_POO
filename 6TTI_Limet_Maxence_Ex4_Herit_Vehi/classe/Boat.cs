using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_Limet_Maxence_Ex4_Herit_Vehi.classe
{
    internal class Boat : Vehicule
    {
        //Attributs
        private double _tonnage;

        //Props
        public double Tonnage
        {
            get { return _tonnage; }
            set { _tonnage = value; }
        }

        //Construct
        public Boat(double fuel, string brand, double tonnage) : base (fuel, brand) 
        {
            _tonnage = tonnage;
        }

        //Méthodes
        public override string AfficheCar()
        {
            string info = $"Votre bateau vient de la marque {Brand}. \n" +
                $"Sa jauge de fuel est de {Fuel} et son tonnage est de {_tonnage}";
            return info;
                            
        }
    }
}
