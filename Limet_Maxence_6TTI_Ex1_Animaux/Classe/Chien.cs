using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Limet_Maxence_6TTI_Ex1_Animaux.Classe
{
    internal class Chien : Animal
    {
        //Attributs

        //Props

        //Construct
        public Chien(string nom, DateTime dateN, int numPuce, double taille, bool concour) : base(nom, dateN, numPuce, taille, concour)
        {
        }

        //Méthodes
        public string Aboyer()
        {
            string info = $"{_nom} vient d'aboyer";
            return info;
        }
    }
}
