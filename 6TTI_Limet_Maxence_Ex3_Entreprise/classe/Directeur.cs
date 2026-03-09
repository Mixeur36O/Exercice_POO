using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_Limet_Maxence_Ex3_Entreprise.classe
{
    internal class Directeur : Employe
    {
        //Attributs
        private double _pourcentage;
        private double _chiffreAff;

        //Props
        public double Pourcentage
        {
            get { return _pourcentage; }
            set { _pourcentage = value; }
        }
        public double ChiffreAff
        {
            get { return _chiffreAff; }
            set { _chiffreAff = value; }
        }


        //Construct
        public Directeur(double pourcentage, double chiffreAff, string matricule, string nom, string prenom, DateTime dateN) : base(matricule, nom, dateN, prenom)
        {
            _pourcentage = pourcentage;
            _chiffreAff = chiffreAff;
        }

        //Méthodes
        public override double CalculSalaire()
        {
            double ecu = _pourcentage / 100 * _chiffreAff;
            Salaire = ecu;
            return Salaire;
        }

        public override string AfficheCara()
        {
            string info = $"Vous êtes {Nom} {Prenom}, né le {DateN} et directeur de l'entreprise. \n " +
                        $"Votre matricule est {Matricule} \n" +
                        $"Votre salaire est mtn de {this.CalculSalaire()}";
            return info;
        }
    }
}
