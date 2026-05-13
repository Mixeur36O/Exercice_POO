using System;
using System.Collections.Generic;
using System.Text;

namespace Limet_Maxence_Act11.classe
{
    internal class Salle
    {
        //attributs
        private string _nom;
        private int _nombrePlaces;

        //Props
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        public int NombrePlaces
        {
            get { return _nombrePlaces; }
            set { _nombrePlaces = value; }
        }

        //Construct
        public Salle(string nom, int nombrePlaces)
        {
            _nom = nom;
            _nombrePlaces = nombrePlaces;
        }

        //Méthode
        public string infos()
        {
            string infos = $"C'est la salle de {_nom} qui à {_nombrePlaces} de places";
            return infos;
        }

    }
}
