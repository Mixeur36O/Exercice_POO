using System;
using System.Collections.Generic;
using System.Text;

namespace Limet_Maxence_Act11.classe
{
    internal class Ecole
    {
        //attributs
        private string _codeEcole;
        private string _adresse;
        private List<Salle> _listSalles;
        private List<Departement> _listDepartements;

        //Props
        public string CodeEcole
        {
            get { return _codeEcole; }
            set { _codeEcole = value; }
        }
        public string Adresse
        {
            get { return _adresse; }
            set { _adresse = value; }
        }
        public List<Salle> ListSalles
        {
            get { return _listSalles; }
            set { _listSalles = value; }
        }
        public List<Departement> ListDepartements
        {
            get { return _listDepartements; }
            set { _listDepartements = value; }
        }

        //Construct
        public Ecole(string codeEcole, string adresse)
        {
            _codeEcole = codeEcole;
            _adresse= adresse;
            _listSalles= new List<Salle>();
            _listDepartements = new List<Departement>();
        }

        //Méthodes
        public void AjouteDepartement(Departement departement)
        {
            _listDepartements.Add(departement);
        }

        public string afficheDepartements()
        {
            string infos = "";
            for (int iDepart = 0; iDepart < _listDepartements.Count; iDepart++)
            {
                infos += $"Les departements qui se situe dans l'école sont {_listDepartements[iDepart]}";
            }
            return infos;
        }
        

    }
}
