using System;
using System.Collections.Generic;
using System.Text;

namespace Limet_Maxence_Act11.classe
{
    internal class Enseignant : Personne
    {
        //attributs
        private DateTime _datePriseFct;
        private List<Cours> _listCours;

        //Props
        public DateTime DatePriseFct
        {
            get { return _datePriseFct; }
        }
        public List<Cours> ListCours
        {
            get { return _listCours; }
            set { _listCours = value; }
        }

        //Construct
        public Enseignant(DateTime datePriseFct, string nom, string prenom, string email, string tel) : base (nom, prenom, email, tel)
        {
            _datePriseFct = datePriseFct;
            _listCours= new List<Cours>();
        }

        //Méthodes
        public override string Infos()
        {
            string info = $"L'enseignant si dessous s'appelle {Nom} {Prenom}, il a pour email {Email}. \n" +
                $"Son numéro de teléphone est {Tel}. "
        }
    }
}
