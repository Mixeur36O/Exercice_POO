using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_Limet_Maxence_Ex3_Entreprise.classe
{
    internal abstract class Employe
    {
        //Attributs
        private string _matricule;
        private string _nom;
        private DateTime _dateN;
        private string _prenom;

        //Props
        public string Matricule
        {
            get { return _matricule; }
            set { _matricule = value; }
        }
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        public DateTime DateN
        {
            get { return _dateN; }
            set { _dateN = value; }
        }
        public string Prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }

        //Construct
        public Employe(string matricule, string nom, DateTime dateN, string prenom)
        {
            _nom = nom;
            _dateN = dateN;
            _prenom = prenom;
            _matricule = matricule;
        }

        //Méthodes
        public abstract double CalculSalaire();

        public abstract string AfficheCara();

    }
}
