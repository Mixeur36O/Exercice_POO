using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_Limet_Maxence_Bibli.classe
{
    internal class Bibliotheque : Livre
    {
        //Attributs
        private List<string> _livres;

        //Props

        public List<string> Livres
        {
            get { return _livres; }
            set { _livres = value; }
        }

        //Construct
        public Bibliotheque(List<string> livres, string titre, string auteur, string etat) : base(titre, auteur, etat)
        {
            _livres = livres;
        }

        //Méthodes
        public void Ajoute(Livre livre)
        {
            List<string> _livre = [Titre,Auteur,Etat];
        }

        public void supprime_livres_abimes()
        {

        }

        public List<string> inventaire()
        {
            return _livres;
        }
    }
}
