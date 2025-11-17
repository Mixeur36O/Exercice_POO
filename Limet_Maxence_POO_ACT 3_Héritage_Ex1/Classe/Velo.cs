using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Limet_Maxence_POO_ACT_3_Héritage_Ex1.Classe
{
    internal class Velo : Vheicule
    {
        //Attributs
        private string _type;
        private bool _estElectrique;

        //Propriétées
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public bool EstElectrique
        {
            get { return _estElectrique; }
            set { _estElectrique = value; }
        }

        //Constructeur
        public Velo(string modele, string marque, string couleur, decimal prix, string type, bool estElectrique) : base (modele, marque, couleur, prix)
        {
            _estElectrique= estElectrique;
            _type = type;
        }

        //Méthodes

        public override string Affiche()
        {
            string info = base.Affiche() + $"\n type ";
            return info;
        }
    }
}
