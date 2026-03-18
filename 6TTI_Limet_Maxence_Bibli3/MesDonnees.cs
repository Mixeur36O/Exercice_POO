using _6TTI_Limet_Maxence_Bibli.classe;
using MySql.Data.MySqlClient;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;


namespace _6TTI_Limet_Maxence_Bibli
{
    internal class MesDonnees
    {
        public string DefinirCheminBD() // détermine la chaîne de connexion
        {
            return "server=10.10.51.98;database=biblio;port=3306;User Id=Maxence;password=root";
        }

        public bool ChercheContenuTab(string table, out DataSet contenutab)
        {
            bool ok = false;
            MySqlConnection maConnexion = new MySqlConnection(DefinirCheminBD());
            string query = "";
            try
            {
                maConnexion.Open();
                query = "SELECT * FROM " + table + ";";

                MySqlDataAdapter da = new MySqlDataAdapter(query, maConnexion);
                contenutab = new DataSet();
                da.Fill(contenutab, "infoUtilisateurs");

                if (contenutab.Tables[0].Rows.Count >= 1)
                {
                    ok = true;
                }
                maConnexion.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
            return ok;
        }

        public bool AjouteAbonne(Abonne abo)
        {
            bool ok = false;
            MySqlConnection maConnexion = new MySqlConnection(DefinirCheminBD());
            string query = "";
            try
            {
                maConnexion.Open();
                query = "INSERT INTO abonnes (nom, prenom, email, login, motDePasse) values (@nom, @prenom, @email, @login, @motDePasse);";

                MySqlCommand insertCommand = new MySqlCommand(query, maConnexion);

                insertCommand.Parameters.AddWithValue("@nom", abo.Nom);
                insertCommand.Parameters.AddWithValue("@prenom", abo.Prenom);
                insertCommand.Parameters.AddWithValue("@email", abo.Email);
                insertCommand.Parameters.AddWithValue("@login", abo.Login);
                insertCommand.Parameters.AddWithValue("@motDePasse", abo.Password);

                // Ajout des données à la source de données
                if (insertCommand.ExecuteNonQuery() > 0)
                {
                    ok = true;
                }
                maConnexion.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
            return ok;
        }

        public bool AjouteLivre(string nom, string prenom, string titre, double anneeP, int etat, out int id)
        {
            id = 0;
            bool ok = false;
            MySqlConnection maConnexion = new MySqlConnection(DefinirCheminBD());
            string query = "";
            try
            {
                maConnexion.Open();
                query = "INSERT INTO livres (nom, prenom, titre, annee_parution, etat) values (@nom, @prenom, @titre, @annee_parution, @etat);";

                MySqlCommand insertCommand = new MySqlCommand(query, maConnexion);

                insertCommand.Parameters.AddWithValue("@nom", nom);
                insertCommand.Parameters.AddWithValue("@prenom", prenom);
                insertCommand.Parameters.AddWithValue("@titre", titre);
                insertCommand.Parameters.AddWithValue("@annee_parution", anneeP);
                insertCommand.Parameters.AddWithValue("@etat", etat);

                // Ajout des données à la source de données
                if (insertCommand.ExecuteNonQuery() > 0)
                {
                    ok = true;
                    id = (int)insertCommand.LastInsertedId;
                }
                maConnexion.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
            return ok;
        }

        public bool DegradL(int id)
        {
            bool ok = false;
            MySqlConnection maConnexion = new MySqlConnection(DefinirCheminBD());
            string query = "";
            try
            {
                maConnexion.Open();
                query = $"UPDATE livres SET etat = etat-1 WHERE Id = {id};";

                MySqlCommand insertCommand = new MySqlCommand(query, maConnexion);

                // Ajout des données à la source de données
                if (insertCommand.ExecuteNonQuery() > 0)
                {
                    ok = true;
                }
                maConnexion.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
            return ok;
        }

        public bool SuppL(int etat)
        {
            bool ok = false;
            MySqlConnection maConnexion = new MySqlConnection(DefinirCheminBD());
            string query = "";
            try
            {
                maConnexion.Open();
                query = $"DELETE FROM livres WHERE etat <= 0;";
                MySqlCommand insertCommand = new MySqlCommand(query, maConnexion);

                // Ajout des données à la source de données
                if (insertCommand.ExecuteNonQuery() > 0)
                {
                    ok = true;
                }
                maConnexion.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
            return ok;
        }


        public bool AjouteEmprunt(Emprunt emprunt)
        {
            bool ok = false;
            MySqlConnection maConnexion = new MySqlConnection(DefinirCheminBD());
            string query = "";
            try
            {
                maConnexion.Open();
                query = "INSERT INTO abonnes (idLivre, idAbonne, dateEmprunt, dateRetour) values (@idLivre, @idAbonne, @dateEmprunt, @dateRetour);";

                MySqlCommand insertCommand = new MySqlCommand(query, maConnexion);

                insertCommand.Parameters.AddWithValue("@idLivre", emprunt.LivreEmprunte);
                insertCommand.Parameters.AddWithValue("@idAbonne", emprunt.Emprunteur);
                insertCommand.Parameters.AddWithValue("@dateEmprunt", emprunt.DateEmprunt);
                insertCommand.Parameters.AddWithValue("@dateRetour", emprunt.DateRetour);

                // Ajout des données à la source de données
                if (insertCommand.ExecuteNonQuery() > 0)
                {
                    ok = true;
                    
                }
                maConnexion.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
            return ok;
        }

        public string AfficheDataAbonne(DataSet donnees)
        {
            string infos = "";
            for (int i = 0; i < donnees.Tables[0].Rows.Count; i++)
            {
                infos += donnees.Tables[0].Rows[i]["nom"].ToString() + " | " +
                         donnees.Tables[0].Rows[i]["prenom"].ToString() + " | " +
                         donnees.Tables[0].Rows[i]["email"].ToString() + " | " +
                         donnees.Tables[0].Rows[i]["motDePasse"].ToString() + " | " + "\n";
            }
            return infos;
        }

        public bool AfficheDataLivre(string table, out DataSet donneesL)
        {
            bool ok = false;
            MySqlConnection maConnection = new MySqlConnection(DefinirCheminBD());
            string query = "";
            try
            {
                maConnection.Open();

                query = "SELECT * FROM " + table + ";";

                MySqlDataAdapter da = new MySqlDataAdapter(query, maConnection);
                donneesL = new DataSet();
                da.Fill(donneesL, "infoTable");

                maConnection.Close();

                if (donneesL.Tables[0].Rows.Count >= 1)
                {
                    ok = true;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                throw;
            }
            return ok;
        }

        //public bool TrouveUnLivre(string titreU, out Livre livreExistant, DataSet donneesL)
        //{
        //    bool ok = false;
        //    MySqlConnection maConnection = new MySqlConnection(DefinirCheminBD());
        //    string query = "";
        //    try
        //    {
        //        maConnection.Open();

        //        query = $"SELECT * FROM livre where titre = {titreU}";

        //        MySqlDataAdapter da = new MySqlDataAdapter(query, maConnection);
        //        donneesL = new DataSet();
        //        da.Fill(donneesL, "infoTable");

        //        maConnection.Close();

        //        if (donneesL.Tables[0].Rows.Count >= 1)
        //        {
        //            ok = true;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(ex);
        //        throw;
        //    }
        //    return ok;
        //}
    }
}
