using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_Limet_Maxence_Ex2_Geometrie.classe
{
    internal class Rectangle : Parallelepipede
    {
        //Attributs
        private double _longueur;
        private double _largeur;

        //Props
        public double Longueur
        {
            get { return _longueur; }
            set { _longueur = value; }
        }

        public double Largeur
        {
            get { return _largeur; }
            set { _largeur = value; }
        }

        //Construct
        public Rectangle(double longueur, double largeur, string couleur) : base (couleur)
        {
            _largeur = largeur;
            _longueur = longueur;
        }

        //Méthodes
        public override double CalculSurface()
        {
            double surface = _longueur * _largeur;
            return surface;
        }

        public override double CalculPerimetre()
        {
            double perimetre = (_longueur + _largeur) * 2;
            return perimetre;
        }

        public override string AfficheInfos()
        {
            string info = $"Votre rectangle à pour surface {this.CalculSurface()} et à un périmètre de {this.CalculPerimetre()}. \n" + $"Il est de couleur {_couleur}";
            return info;
        }

    }
}
