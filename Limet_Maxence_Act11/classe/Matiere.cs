using System;
using System.Collections.Generic;
using System.Text;

namespace Limet_Maxence_Act11.classe
{
    internal class Matiere
    {
        //attributs
        private string _nom;

        //Props
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        //Construct
        public Matiere(string nom)
        {
            _nom = nom;
        }

        //Méthodes
    }
}
