using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
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
        MesDonnees donnee = new MesDonnees();
        DataSet donneesL = new DataSet();
        public Bibliotheque()
        {
            _livres = new List<Livre>();
            if (donnee.AfficheDataLivre("livres", donneesL))
            {
                for (int i = 0; i < donneesL.Tables[0].Rows.Count; i++)
                {
                    Livre unLivre = new Livre((int)donneesL.Tables[0].Rows[i]["id"], 
                        donneesL.Tables[0].Rows[i]["nom"].ToString(),
                        donneesL.Tables[0].Rows[i]["prenom"].ToString(),
                        donneesL.Tables[0].Rows[i]["titre"].ToString(),
                        (double)donneesL.Tables[0].Rows[i]["anneeP"],
                        (int)donneesL.Tables[0].Rows[i]["etat"]);
                    _livres.Add(unLivre);
                }
            }
            _abonnes = new List<Abonne>();
            _emprunts = new List<Emprunt>();
        }
        //Méthodes

        public string Ajoute(string nom, string prenom, string titre, double anneeP, int etat)
        {
            string info = "";
            if (donnee.AjouteLivre(nom, prenom, titre, anneeP, etat, out int id))
            {
                _livres.Add(new Livre(id, nom, prenom, titre, anneeP, etat));
                return info = "Le livre a bien été créer";
            }
            else
            {
                return info = "Le livre n'a pas pu être créer.";
            }
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

        public void CreeAbonne(string nom, string prenom, string email, string login, string mdp)
        {
            _abonnes.Add(new Abonne(nom, prenom, email, login, mdp));
            Abonne abo = new Abonne(nom, prenom, email, login, mdp);
            donnee.AjouteAbonne(abo);
        }

        public void AjouteEmpruntLivre(Livre livre, Abonne emprunteur, DateTime dateEmprunt)
        {
            _emprunts.Add(new Emprunt(livre, dateEmprunt, emprunteur));
            Emprunt empr = new Emprunt(livre, dateEmprunt, emprunteur);
            donnee.AjouteEmprunt(empr);
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
