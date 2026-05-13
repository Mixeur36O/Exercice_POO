using System;
using System.Collections.Generic;
using System.Text;

namespace Limet_Maxence_Act11.classe
{
    internal class Departement
    {
        //attributs
        private string _nom;
        private List<Enseignant> _listEnseignants;
        private List<Matiere> _listMatieres;

        //Props
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        public List<Enseignant> ListEnseignants
        {
            get { return _listEnseignants; }
            set { _listEnseignants = value; }
        }
        public List<Matiere> ListMatieres
        {
            get { return _listMatieres; }
            set { _listMatieres = value; }
        }

        //Construct
        public Departement(string nom)
        {
            _nom = nom;
            _listEnseignants= new List<Enseignant>();
            _listMatieres= new List<Matiere>();
        }

        //Méthodes
        public void AjouterEnseignant(Enseignant enseignant) 
        {
            _listEnseignants.Add(enseignant);
        }

    }
}
