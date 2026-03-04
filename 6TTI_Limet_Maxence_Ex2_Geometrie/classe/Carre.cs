using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_Limet_Maxence_Ex2_Geometrie.classe
{
    internal class Carre : Parallelepipede
    {
        //Attributs
        private double _cote;

        //Props
        public double Cote
        {
            get { return _cote; }
            set { _cote = value; }
        }

        //Construct
        public Carre(double cote, string couleur) : base (couleur)
        {
            _cote = cote;
        }

        //Méthodes
        public override double CalculSurface()
        {
            double surface = _cote * _cote;
            return surface;
        }

        public override double CalculPerimetre()
        {
            double perimetre = 4 * _cote;
            return perimetre;
        }

        public override string AfficheInfos()
        {
            string info = $"Votre carre à pour surface {this.CalculSurface()} et à un périmètre de {this.CalculPerimetre()}. \n" + $"Il est de couleur {_couleur}";
            return info;
        }

    }
}
