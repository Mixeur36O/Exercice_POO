using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_Limet_Maxence_Bibli.classe
{
    internal class Emprunt
    {
        //Attributs
        private Livre _livreEmprunte;
        private DateTime _dateEmprunt;
        private DateTime _dateRetour;
        private Abonne _emprunteur;
        private int _id;

        //Props
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public Livre LivreEmprunte
        {
            get { return _livreEmprunte; }
            set { _livreEmprunte = value; }
        }
        public DateTime DateEmprunt
        {
            get { return _dateEmprunt; }
            set { _dateEmprunt = value; }
        }
        public DateTime DateRetour
        {
            get { return _dateRetour; }
            set { _dateRetour = value; }
        }
        public Abonne Emprunteur
        {
            get { return _emprunteur; }
            set { _emprunteur = value; }
        }
        //Construct
        public Emprunt(int id, Livre livre, Abonne emprunteur, DateTime dateEmprunt)
        {
            _id = id;
            _livreEmprunte = livre;
            _dateEmprunt = dateEmprunt;
            _emprunteur = emprunteur;
        }

        //Méthodes

        public string infos()
        {
            string info = $"Le livre emprunter est {_livreEmprunte.Titre}, pris par {_emprunteur.Nom} {_emprunteur.Prenom}. Le {_dateEmprunt}";
            return info;
        }

    }
}
