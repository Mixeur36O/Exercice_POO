using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_Limet_Maxence_Ex2_Geometrie.classe
{
    internal abstract class Parallelepipede
    {
        //Attributs
        protected string _couleur;

        //Props
        public string Couleur
        {
            get { return _couleur; }
            set { _couleur = value; }
        }

        //Construct
        public Parallelepipede(string couleur)
        {
            _couleur = couleur;
        }

        //Méthodes
        public abstract double CalculSurface();


        public abstract double CalculPerimetre();

        public abstract string AfficheInfos();

    }
}
