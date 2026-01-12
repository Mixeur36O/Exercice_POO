using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_Limet_Maxence_Bibli.classe
{
    internal class Livre
    {
        //Attributs
        private string _titre;
        private string _auteur;
        private string _etat;

        //Props

        public string Titre
        {
            get { return _titre; }
        }

        public string Auteur
        {
            get { return _auteur; }
        }

        public string Etat
        {
            get { return _etat; }
            set { _etat = value; }
        }

        //Construct
        public Livre(string titre, string auteur, string etat)
        {
            _titre = titre;
            _auteur = auteur;
            _etat = etat;
        }

        //Méthodes
        public int Degrade()
        {
            int val = 0;
            Console.WriteLine("Dans quel état est votre livre svp (notez entre 0 pour vrmt dégradez à 5 nickel)");
            _etat = Console.ReadLine();
            do
            {
                while (!int.TryParse(_etat, out val))
                {
                    Console.WriteLine("Ce n'est pas entre les nombres demander");
                    Console.WriteLine("Dans quel état est votre livre svp (notez entre 0 pour vrmt dégradez à 5 nickel)");
                    _etat = Console.ReadLine();
                }
            } while (val < 0 || val > 5);
            return val;
        }

        public string Description()
        {
            string infos;
            infos = $"Vous avez choisis de prendre le livre {_titre}, écris par {_auteur}. \n Il est dans l'état {_etat}";
            return infos;
        }
    }
}
