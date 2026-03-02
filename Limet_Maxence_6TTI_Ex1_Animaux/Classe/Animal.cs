using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Limet_Maxence_6TTI_Ex1_Animaux.Classe
{
    internal class Animal
    {
        //Attributs
        protected string _nom;
        protected DateTime _dateN;
        protected int _numPuce;
        protected double _taille;
        protected bool _concour;

        //Props
        public string Nom
        {
            get { return _nom; }
        }

        public DateTime DateN
        {
            get { return _dateN; }
        }

        public int NumPuce
        {
            get { return _numPuce; }
        }

        public double Taille
        {
            get { return _taille; }
            set { _taille = value; }
        }

        public bool Concour
        {
            get { return _concour; }
            set { _concour = value; }
        }

        //Construct
        public Animal(string nom, DateTime dateN, int numPuce, double taille, bool concour)
        {
            _nom = nom;
            _dateN = dateN;
            _numPuce = numPuce;
            _taille = taille;
            _concour = concour;
        }

        //Méthodes
        public string Dormir()
        {
            string info = $"{_nom} est entrain de dormir";
            return info;
        }

        public string Manger()
        {
            string info = $"{_nom} est entrain de manger";
            return info;
        }

        public virtual string Information()
        {
            string info = $"Votre animal porte le nom de {_nom}. \n" +
                $"Il est né le {_dateN} son numéro de puce est {_numPuce}. \n" +
                $"Il mesure {_taille}";
            return info;
        }
    }
}
