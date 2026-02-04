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
        private string _titre;
        private string _auteur;
        private int _etat;

        //Props

        public string Titre
        {
            get { return _titre; }
        }

        public string Auteur
        {
            get { return _auteur; }
        }

        public int Etat
        {
            get { return _etat; }
            set { _etat = value; }
        }

        //Construct
        public Livre(string titre, string auteur, int etat)
        {
            _titre = titre;
            _auteur = auteur;
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
            infos = $"{_titre}, écris par {_auteur}. \n Il est dans l'état {_etat}";
            return infos;
        }
    }
}
