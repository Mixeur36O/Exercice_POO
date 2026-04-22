using System;
using System.Collections.Generic;
using System.Text;

namespace Limet_Maxence_Act11.classe
{
    abstract internal class Personne
    {
        //Attributs
        private string _nom;
        private string _prenom;
        private string _email;
        private string _tel;

        //Props

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        public string Prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string Tel
        {
            get { return _tel; }
            set { _tel = value; }
        }

        //Construct

        //Méthodes
    }
}
