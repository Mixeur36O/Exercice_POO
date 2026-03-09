using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_Limet_Maxence_Ex3_Entreprise.classe
{
    internal class Ouvrier : Employe
    {
        //Attributs
        private DateTime _dateEE;

        //Props
        public  DateTime DateEE
        {
            get { return _dateEE; }
        }

        //Construct
        public Ouvrier(DateTime dateEE, string matricule, string nom, string prenom, DateTime dateN) : base (matricule, nom, dateN, prenom)
        {
            _dateEE = dateEE;
        }

        //Méthodes
        public override double CalculSalaire()
        {
            DateTime auj = DateTime.Today;
            int annee = auj.Year - _dateEE.Year;
            double ecu = 2500;
            ecu = ecu + (100 * annee);
            if (ecu > 2*2500)
            {
                ecu = 5000;
            }
            Salaire = ecu;
            return Salaire;
        }

        public override string AfficheCara()
        {
            string info = $"Vous êtes {Nom} {Prenom}, né le {DateN}. \n et Ouvrier de l'entreprise" +
                $"Vous êtes entré(e) ici le {_dateEE} et votre matricule est {Matricule} \n" +
                $"Votre salaire est mtn de {this.CalculSalaire()}";
            return info;
        }
    }
}
