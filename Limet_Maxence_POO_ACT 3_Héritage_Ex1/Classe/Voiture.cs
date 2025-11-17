using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Limet_Maxence_POO_ACT_3_Héritage_Ex1.Classe
{
    internal class Voiture : Vheicule
    {
        //Attributs
        private string _motorisation;
        private bool _gps;

        //Propriétées

        public string Motorisation
        {
            get { return _motorisation; }
        }
        public bool Gps
        {
            get { return _gps; }
            set { _gps = value; }
        }

        //Constructeur
        public Voiture(string modele, string marque, string couleur, decimal prix, string motorisation, bool GPS) : base (modele, marque, couleur, prix)
        {
            _motorisation = motorisation;
            _gps = GPS;
        }

        //Méthodes
        public override string Affiche()
        {
            string info = base.Affiche() + $"\n sa motorisation est {_motorisation}. \n Y a t'il un GPS {_gps}";
            return info;
        }
    }
}
