using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Limet_Maxence_6TTI_Ex1_Animaux.Classe
{
    internal class Lapin : Animal
    {
        //Attributs
        private double _tailleOreille;

        //Props
        public double TailleOreille
        {
            get { return _tailleOreille; }
            set { _tailleOreille = value; }
        }

        //Construct
        public Lapin(string nom, DateTime dateN, int numPuce, double taille, bool concour, double tailleOreille) : base (nom, dateN, numPuce, taille, concour)
        {
            _tailleOreille = tailleOreille;
        }

        //Méthodes
        public string Bondir()
        {
            string info = $"{_nom} vient de bondir";
            return info;
        }

        public override string Information()
        {
            string info = $"Votre animal porte le nom de {_nom}. \n" +
                $"Il est né le {_dateN} son numéro de puce est {_numPuce}. \n" +
                $"Il mesure {_taille} de plus sa taille d'oreille est {_tailleOreille}.";
            return info;
        }
    }
}
