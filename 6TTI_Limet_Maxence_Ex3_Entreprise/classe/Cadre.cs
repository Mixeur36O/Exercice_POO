using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_Limet_Maxence_Ex3_Entreprise.classe
{
    internal class Cadre : Employe 
    {
        //Attributs
        private int _indice;

        //Props
        public int Indice
        {
            get { return _indice; }
            set { _indice = value; }
        }

        //Construct
        public Cadre(int indice, string matricule, string nom, string prenom, DateTime dateN) : base(matricule, nom, dateN, prenom)
        {
            _indice = indice;
        }

        //Méthodes
        public override double CalculSalaire()
        {
            double ecu = 0;
            if (_indice == 1)
            {
                ecu = Tarification.Sal_1;
            }
            else if (_indice == 2)
            {
                ecu = Tarification.Sal_2;
            }
            else if (_indice == 3)
            {
                ecu = Tarification.Sal_3;
            }
            else if (_indice == 4)
            {
                ecu = Tarification.Sal_4;
            }
            Salaire = ecu;
            return Salaire;

        }

        public override string AfficheCara()
        {
            string info = $"Vous êtes {Nom} {Prenom}, né le {DateN} et cadre de l'entreprise. \n " +
                        $"Votre matricule est {Matricule} \n" +
                        $"Votre salaire est mtn de {this.CalculSalaire()}";
            return info;
        }
    }
}
