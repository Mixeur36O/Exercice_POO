using System;
using System.Collections.Generic;
using System.Text;

namespace Limet_Maxence_Act11.classe
{
    internal class Cours
    {
        //attributs
        private Matiere _matiere;
        private Salle _salle;
        private string _nom;
        private List<double> _listNotes;
        private List<Etudiant> _listEtudiants;

        //Props
        public Matiere Matiere
        {
            get { return _matiere; }
        }
        public Salle Salle
        {
            get { return _salle; }
            set { _salle = value; }
        }
        public string Nom
        {
            get { return _nom; }
        }
        public List<double> ListNotes
        {
            get { return _listNotes; }
            set { _listNotes = value; }
        }
        public List<Etudiant> ListEtudiants
        {
            get { return _listEtudiants; }
            set { _listEtudiants = value; }
        }

        //Construct
        public Cours(Matiere matiere, Salle salle, string nom)
        {
            _matiere = matiere;
            _salle = salle;
            _nom = nom;
            _listNotes = new List<double>();
            _listEtudiants= new List<Etudiant>();
        }

        //Méthodes
        public void AjouteNote(double note)
        {
            _listNotes.Add(note);
        }

        public void AjouteEtudiant(Etudiant etudiant)
        {
            _listEtudiants.Add(etudiant);
        }

        public double CalculMoyCours()
        {
            double moy = 0;
            for (int iMoy = 0;  iMoy < _listNotes.Count; iMoy++)
            {
                moy += _listNotes[iMoy];
            }
            return moy;
        }

    }
}
