using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_Limet_Maxence_Bibli.classe
{
    internal class Bibliotheque
    {
        //Attributs
        private List<Livre> _livres;
        private List<Emprunt> _emprunts;
        private List<Abonne> _abonnes;

        //Props

        public List<Livre> Livres
        {
            get { return _livres; }
        }

        public List<Emprunt> Emprunts
        {
            get { return _emprunts; }
        }

        public List<Abonne> Abonnes
        {
            get { return _abonnes; }
            set { _abonnes = value; }
        }
        //Construct
        public Bibliotheque()
        {
            _livres = new List<Livre>();
        }

        //Méthodes
        public void Ajoute(Livre livre)
        {
             _livres.Add(livre);
        }

        public void supprime_livres_abimes()
        {
            for (int iBiblio = 0; iBiblio < _livres.Count; iBiblio++)
            {
                if (_livres[iBiblio].Etat == 0)
                {
                    _livres.Remove(_livres[iBiblio]);
                }
            }
        }

        public string inventaire()
        {
            string infos = "";
            for (int iBiblio = 0; iBiblio < _livres.Count; iBiblio++)
            {
                infos += $"Il y a comme livre : {_livres[iBiblio].Description()} \n";
            }
            return infos;

        }

        public void CreeAbonne(string nom, string prenom, string email)
        {
            _abonnes.Add(new Abonne(nom, prenom, email));
        }

        public void AjouteEmpruntLivre(Livre livre, Abonne emprunteur, DateTime dateEmprunt)
        {
            _emprunts.Add(new Emprunt(livre, dateEmprunt, emprunteur));
        }

        public string NotifieRetourLivre(Emprunt emprunt, DateTime dateRetour)
        {
            emprunt.DateRetour = dateRetour;
            return "Retour réussis";

        }

        public string ListeLivresEmprunts()
        {
            string infos = "";
            for (int iBiblio = 0; iBiblio < _abonnes.Count; iBiblio++)
            {
                infos += $"Les livres empruntr sont : {_livres[iBiblio].Description()} par {_abonnes[iBiblio].infos()} \n";
            }
            return infos;
        }
    }
}
