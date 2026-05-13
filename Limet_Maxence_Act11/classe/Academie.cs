using System;
using System.Collections.Generic;
using System.Text;

namespace Limet_Maxence_Act11.classe
{
    internal class Academie
    {
        //attributs
        private string _nom;
        private List<Ecole> _listeEcole;

        //Props
        public List<Ecole> ListeEcole
        {
            get { return _listeEcole; }
            set { _listeEcole = value; }
        }
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        //Construct
        public Academie(string nom)
        {
            _nom = nom;
            _listeEcole = new List<Ecole>();
        }

        //Méthodes
        public void AjouteEcole(Ecole ecole)
        {
            _listeEcole.Add(ecole);
        }

        public string AfficheEcoles()
        {
            string infos = "";
            for (int iEcole = 0; iEcole < _listeEcole.Count; iEcole++)
            {
                infos += $"Les ecoles qui se situe dans l'academie sont {_listeEcole[iEcole]}";
            }
            return infos;
        }

    }
}
