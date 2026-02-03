using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_Limet_Maxence_Bibli.classe
{
    internal class Abonne
    {
        //Attributs
        private string _nom;
        private string _prenom;
        private string _email;

        //Props
        public string Nom
        {
            get { return _nom; }
        }
        public string Prenom
        {
            get { return _prenom; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        //Construct
        public Abonne(string nom, string prenom, string email)
        {
            _nom = nom;
            _prenom = prenom;
            _email = email;
        }

        //Méthodes

        public string infos()
        {
            string info = $"L'abonner {_nom} {_prenom}. Son adresse mail est {_email}";
            return info;
        }
    }
}
