using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_Limet_Maxence_Cercle.Classe
{
    internal class cercle
    {
        //Attributs
        private double _rayon;

        //Propriétées

        public double Rayon
        {
            get { return _rayon; }
            set { _rayon = value; }
        }

        //Constructeur
        public cercle(double rayon)
        {
            _rayon = rayon;
        }

        //Méhodes
        public string CalculerPerimetreAir()
        {
            double perimetre;
            perimetre = 2 * Math.PI * _rayon;
            double air;
            air = Math.PI * Math.Pow(_rayon, 2);
            string info = $"Votre périmetre est de {perimetre} et votre air est de {air}";
            return info;

        }

        public string CalculerPerimetreAir2()
        {
            double perimetre;
            perimetre = 2 * Math.PI * (_rayon / 2);
            double air;
            air = Math.PI * (Math.Pow(_rayon, 2) / 2);
            string info = $"Votre périmetre est de {perimetre} et votre air est de {air}";
            return info;
        }
    }
}
