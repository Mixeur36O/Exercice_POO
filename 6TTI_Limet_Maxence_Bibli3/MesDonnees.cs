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

        public bool AjouteAbonne(string nom, string prenom, string email, string login, string motDePasse, out int id)
        {
            id = 0;
            bool ok = false;
            MySqlConnection maConnexion = new MySqlConnection(DefinirCheminBD());
            string query = "";
            try
            {
                maConnexion.Open();
                query = "INSERT INTO abonnes (nom, prenom, email, login, motDePasse) values (@nom, @prenom, @email, @login, @motDePasse);";

                MySqlCommand insertCommand = new MySqlCommand(query, maConnexion);

                insertCommand.Parameters.AddWithValue("@nom", nom);
                insertCommand.Parameters.AddWithValue("@prenom", prenom);
                insertCommand.Parameters.AddWithValue("@email", email);
                insertCommand.Parameters.AddWithValue("@login", login);
                insertCommand.Parameters.AddWithValue("@motDePasse", motDePasse);

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


        public bool AjouteEmprunt(int idL, int idA, DateTime dateemprunt, DateTime dateRetour, out int id)
        {
            bool ok = false;
            id = 0;
            MySqlConnection maConnexion = new MySqlConnection(DefinirCheminBD());
            string query = "";
            try
            {
                maConnexion.Open();
                query = "INSERT INTO emprunts (idLivre, idAbonne, dateEmprunt, dateRetour) values (@idLivre, @idAbonne, @dateEmprunt, @dateRetour);";

                MySqlCommand insertCommand = new MySqlCommand(query, maConnexion);

                insertCommand.Parameters.AddWithValue("@idLivre", idL);
                insertCommand.Parameters.AddWithValue("@idAbonne", idA);
                insertCommand.Parameters.AddWithValue("@dateEmprunt", dateemprunt);
                insertCommand.Parameters.AddWithValue("@dateRetour", dateRetour);

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

        public bool AfficheData(string table, out DataSet donneesL)
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

    }
}
