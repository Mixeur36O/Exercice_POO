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
        MethodeProgramme mtdPro = new MethodeProgramme();
        public Bibliotheque()
        {
            _livres = new List<Livre>();
            if (donnee.AfficheData("livres", out donneesL))
            {
                for (int i = 0; i < donneesL.Tables[0].Rows.Count; i++)
                {
                    Livre unLivre = new Livre((int)donneesL.Tables[0].Rows[i]["id"],
                        donneesL.Tables[0].Rows[i]["nom"].ToString(),
                        donneesL.Tables[0].Rows[i]["prenom"].ToString(),
                        donneesL.Tables[0].Rows[i]["titre"].ToString(),
                        (int)donneesL.Tables[0].Rows[i]["annee_parution"],
                        (int)donneesL.Tables[0].Rows[i]["etat"]);
                    _livres.Add(unLivre);
                }
            }
            _abonnes = new List<Abonne>();
            if (donnee.AfficheData("abonnes", out donneesL))
            {
                for (int i = 0; i < donneesL.Tables[0].Rows.Count; i++)
                {
                    Abonne unAbonne = new Abonne((int)donneesL.Tables[0].Rows[i]["id"],
                        donneesL.Tables[0].Rows[i]["nom"].ToString(),
                        donneesL.Tables[0].Rows[i]["prenom"].ToString(),
                        donneesL.Tables[0].Rows[i]["email"].ToString(),
                        donneesL.Tables[0].Rows[i]["login"].ToString(),
                        donneesL.Tables[0].Rows[i]["motDePasse"].ToString());
                    _abonnes.Add(unAbonne);
                }
            }
            _emprunts = new List<Emprunt>();
            if (donnee.AfficheData("emprunts", out donneesL))
            {
                for (int i = 0; i < donneesL.Tables[0].Rows.Count; i++)
                {
                    Livre livreExistent;
                    if (mtdPro.TrouveLivre((int)donneesL.Tables[0].Rows[i]["idLivre"], _livres, out livreExistent))
                    {
                        Abonne aboExistant;
                        if (mtdPro.TrouveEmprunteur((int)donneesL.Tables[0].Rows[i]["idAbonne"], _abonnes, out aboExistant))
                        {
                            Emprunt unEmprunt = new Emprunt((int)donneesL.Tables[0].Rows[i]["idEmprunt"], livreExistent, aboExistant, (DateTime)donneesL.Tables[0].Rows[i]["dateEmprunt"]);
                            _emprunts.Add(unEmprunt);
                        }
                    } 
                }
            }

        }
        //Méthodes

        public string Ajoute(string nom, string prenom, string titre, int anneeP, int etat)
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
                if (_livres[iBiblio].Etat <= 0)
                {
                    _livres.Remove(_livres[iBiblio]);
                    donnee.SuppL(_livres[iBiblio].Etat);
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

        public string ListAbonne()
        {
            string infos = ""; 
            for (int iBiblio = 0; iBiblio < _abonnes.Count; iBiblio++)
            {
                infos += $"Il y a comme abonné : {_abonnes[iBiblio].infos()} \n";
            }
            return infos;
        }

        public string CreeAbonne(string nom, string prenom, string email, string login, string mdp)
        {
            string info = "";
            if (donnee.AjouteAbonne(nom, prenom, email, login, mdp, out int id))
            {
                _abonnes.Add(new Abonne(id, nom, prenom, email, login, mdp));
                return info = "Vous vous êtes bien abonné";
            }
            else
            {
                return info = "Il y a eu une erreur avec la base de donnée, désolé";
            }
        }

        public void AjouteEmpruntLivre(Livre livre, Abonne abonne, DateTime dateEmprunt)
        {
            string info = "";
            DateTime aujourdhui = DateTime.Now;
            DateTime dateRetour = aujourdhui.AddDays(15);
            donnee.AjouteEmprunt(livre.Id, abonne.Id, dateEmprunt, dateRetour, out int id);
            _emprunts.Add(new Emprunt(id, livre, abonne, dateEmprunt));
        }


        public string NotifieRetourLivre(Emprunt emprunt, DateTime dateRetour)
        {
            emprunt.DateRetour = dateRetour;
            return "Retour réussis";
        }

        public string ListeLivresEmprunts()
        {
            string infos = "";
            for (int iBiblio = 0; iBiblio < _emprunts.Count; iBiblio++)
            {
                infos += $"Les livres emprunter sont {_emprunts[iBiblio].infos()} \n";
            }
            return infos;
        }
    }
}
