using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Limet_Maxence_POO_ACT_3_Héritage_Ex1.Classe
{
    internal class Vheicule
    {

        //Attributs
        protected string _modele;
        protected string _marque;
        protected string _couleur;
        protected decimal _prix;

        //Propriétées

        public string Modele 
        {
            get { return _modele; }
        }

        public string Marque
        {
            get { return _marque; }
        }

        public string Couleur
        {
            get { return _couleur; }
        }

        public decimal Prix
        {
            get { return _prix; }
            set { _prix = value; }
        }

        //Constructeur
        public Vheicule(string modele, string marque, string couleur, decimal prix)
        {
            _modele = modele;
            _marque = marque;
            _couleur = couleur;
            _prix = prix;
        }


        //Méthodes

        public virtual string Affiche()
        {
            string info = $"Le modele de votre vhéicule est {_modele} \n sa marque est {_marque} \n il est de couleur {_couleur} \n et son prix est de {_prix}";
            return info;
        }

    }
}
