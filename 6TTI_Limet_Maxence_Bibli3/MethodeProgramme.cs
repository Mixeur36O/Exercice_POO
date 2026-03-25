using _6TTI_Limet_Maxence_Bibli.classe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_Limet_Maxence_Bibli
{
    internal class MethodeProgramme
    {
        public bool TrouveLivre(int idU, List<Livre> biblio, out Livre livre)
        {
            bool trouve = false;
            livre = null;
            foreach (Livre item in biblio)
            {
                if (item.Id == idU)
                {
                    livre = item;
                    trouve = true;
                }
            }
            return trouve;
        }

        public bool TrouveEmprunteur(int idU, List<Abonne> biblio, out Abonne emprunteur)
        {
            bool trouve = false;
            emprunteur = null;
            foreach (Abonne item in biblio)
            {
                if (item.Id == idU)
                {
                    emprunteur = item;
                    trouve = true;
                }
            }
            return trouve;

        }

        public void DonneeUti(string entreeU, out int val)
        {
            val = 0;
            Console.WriteLine("En quelle année est-il parru ?");
            entreeU = Console.ReadLine();
            while (!int.TryParse(entreeU, out val))
            {
                Console.WriteLine("Ce nest pas une année conforme");
                Console.WriteLine("En quelle année est-il parru ?");
                entreeU = Console.ReadLine();
            }
        }

        public void DonneeID(string entreeU, out int val)
        {
            val = 0;
            Console.WriteLine("Donné-moi un ID");
            entreeU = Console.ReadLine();
            while (!int.TryParse(entreeU, out val))
            {
                Console.WriteLine("Ce nest pas un Id conforme");
                Console.WriteLine("Donné-moi un ID");
                entreeU = Console.ReadLine();
            }
        }

        public bool TrouveUnLivre(string titreU, List<Livre> biblio, out Livre livreExistant)
        {
            bool ok = false;
            livreExistant = null;
            foreach (Livre item in biblio)
            {
                if (item.Titre == titreU)
                {
                    livreExistant = item;
                    ok = true;
                }
            }
            return ok;
        }

        public bool TrouveUnAbonne(string loginU, List<Abonne> biblio, out Abonne abonneExistant)
        {
            bool ok = false;
            abonneExistant = null;
            foreach (Abonne item in biblio)
            {
                if (item.Login == loginU)
                {
                    abonneExistant = item;
                    ok = true;
                }
            }
            return ok;
        }
    }
}
