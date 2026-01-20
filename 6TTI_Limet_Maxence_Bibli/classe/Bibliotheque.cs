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

        //Props

        public List<Livre> Livres
        {
            get { return _livres; }
            set { _livres = value; }
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
    }
}
