using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_Limet_Maxence_Bibli.classe
{
    internal class Livre
    {
        //Attributs
        private int _id;
        private string _titre;
        private string _nom;
        private string _prenom;
        private double _anneeP;
        private int _etat;

        //Props
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }


        public string Titre
        {
            get { return _titre; }
        }

        public string Prenom
        {
            get { return _prenom; }
        }
        public string Nom
        {
            get { return _nom; }
        }
        public double AnneeP
        {
            get { return _anneeP; }
        }
        public int Etat
        {
            get { return _etat; }
            set { _etat = value; }
        }

        //Construct
        public Livre(int id, string nom, string prenom, string titre, double anneeP, int etat)
        {
            _id = id;
            _nom = nom;
            _prenom = prenom;
            _titre = titre;
            _anneeP = anneeP;
            _etat = etat;
        }

        //Méthodes
        public void Degrade()
        {
            _etat -= 1;
        }

        public string Description()
        {
            string infos;
            infos = $"{_titre}, écris par {_nom} {_prenom} en {AnneeP}. \n Il est dans l'état {_etat}";
            return infos;
        }
    }
}
