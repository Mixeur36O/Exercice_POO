using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Limet_Maxence_6TTI_Ex1_Animaux.Classe
{
    internal class Chat : Animal
    {
        //Attributs

        //Props

        //Construct
        public Chat(string nom, DateTime dateN, int numPuce, double taille, bool concour) : base(nom, dateN, numPuce, taille, concour)
        {
        }

        //Méthodes
        public string Miauler()
        {
            string info = $"{_nom} vient de miauler";
            return info;
        }

        public string Ronronner()
        {
            string info = $"{_nom} vient de ronronner";
            return info;
        }
    }
}
