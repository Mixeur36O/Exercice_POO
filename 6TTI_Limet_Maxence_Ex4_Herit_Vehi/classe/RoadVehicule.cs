using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_Limet_Maxence_Ex4_Herit_Vehi.classe
{
    internal abstract class RoadVehicule : Vehicule
    {
        //Attributs
        protected double _km;

        //Props
        public double Km
        {
            get { return _km; }
            set { _km = value; }
        }

        //Construct
        public RoadVehicule(double fuel, string brand, double km) : base (fuel, brand) 
        {

        }

        //Méthodes

    }
}
