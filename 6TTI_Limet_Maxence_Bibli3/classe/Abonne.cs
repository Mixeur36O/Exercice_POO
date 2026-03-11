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
        private string _login;
        private string _password;

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
        public string Login
        {
            get { return _login; }
            set { _login = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        //Construct
        public Abonne(string nom, string prenom, string email, string login, string mdp)
        {
            _nom = nom;
            _prenom = prenom;
            _email = email;
            _login = login;
            _password = mdp;
        }

        //Méthodes

        public string infos()
        {
            string info = $"L'abonner {_nom} {_prenom}. Son adresse mail est {_email}";
            return info;
        }
    }
}
