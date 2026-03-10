using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_Limet_Maxence_Ex4_Herit_Vehi.classe
{
    internal abstract class Vehicule
    {
        //Attributs
        protected double _fuel;
        protected string _brand;

        //Props
        public double Fuel
        {
            get { return _fuel; }
            set { _fuel = value; }
        }
        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        //Construct
        public Vehicule(double fuel, string brand)
        {
            _fuel = fuel;
            _brand = brand;
        }

        //Méthodes
        public abstract string AfficheCar();
    }
}
