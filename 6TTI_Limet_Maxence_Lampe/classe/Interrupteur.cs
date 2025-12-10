using System;
using System.Collections.Generic;
using System.Text;

namespace _6TTI_Limet_Maxence_Lampe.classe
{
    internal class Interrupteur
    {
        //Attributs
        private bool _allumage;

        //Props
        public bool Allumage
        {
            get { return _allumage; }
            set { _allumage = value; }
        }


        //Constru
        public Interrupteur(bool allumage)
        {
            _allumage = allumage;
        }

        //Méthodes
        public string AllumageL()
        {
            if (_allumage == true)
            {
                string info = "Votre lampe est allumé";
                return info;
            }
            else
            {
                string info = "Votre lampe est étteinte";
                return info;
            }
        }

    }
}
