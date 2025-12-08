using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_Limet_Maxence_NombreComplexe.classe
{
    internal class Complexe
    {
        //Attibuts
        private double _reel;
        private double _imaginaire;

        //Propriétées
        public double Reel
        {
            get { return _reel; }
            set { _reel = value; }
        }
        public double Imaginaire
        {
            get { return _imaginaire; }
            set { _imaginaire = value; }
        }

        //Constructeur
        public Complexe(double reel, double imaginaire)
        {
            _reel = reel;
            _imaginaire = imaginaire;
        }

        //Méthodes
        public string CalculeModule()
        {
            double module = Math.Sqrt(Math.Pow(_reel,2) + Math.Pow(_imaginaire, 2));
            string info = $"Le premier complexe est : ({_reel},{_imaginaire}) a pour module : {module}";
            return info;
        }
        public string AfficheComplexe()
        {
            string info = $"Le second complexe est : ({Reel},{Imaginaire})";
            return info;
        }

        public string Ajoute()
        {
            double addiCompR = Reel + _reel;
            double addiCompI = Imaginaire +  _imaginaire;
            string info = $"Le premier complexe devient : ({addiCompR},{addiCompI}) après ajout du second";
            return info;
        }
    }
}
