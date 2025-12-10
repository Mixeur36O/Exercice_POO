using System;
using System.Collections.Generic;
using System.Text;

namespace _6TTI_Limet_Maxence_Lampe.classe
{
    internal class Lampe
    {
        //Attributs
        private string _couleur;
        private string _type;

        //Props
        public string Couleur
        {
            get { return _couleur; }
        }

        public string Type
        {
            get { return _type; }
        }

        //Constru
        public Lampe(string couleur, string type)
        {
            _couleur = couleur;
            _type = type;
        }

        //Méthodes
        public string CaractéristiqueL()
        {
            string infos = $"Lampe de couleur : {_couleur}, elle est sur {_type}";
            return infos;
        }

    }
}
