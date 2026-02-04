using MySql.Data.MySqlClient;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _6TTI_Limet_Maxence_Bibli
{
    internal class MesDonnees
    {
        public string DefinirCheminBD() // détermine la chaîne de connexion
        {
            return "server=localhost;database=biblio;port=3306;User Id=Maxence;password=root";
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

        public bool AjouteAbonne(string[] donnees)
        {
            bool ok = false;
            MySqlConnection maConnexion = new MySqlConnection(DefinirCheminBD());
            string query = "";
            try
            {
                maConnexion.Open();
                query = "INSERT INTO abonnes (nom, prenom, email, motDePasse) values (@nom, @prenom, @email, @motDePasse);";

                MySqlCommand insertCommand = new MySqlCommand(query, maConnexion);

                insertCommand.Parameters.AddWithValue("@nom", donnees[0]);
                insertCommand.Parameters.AddWithValue("@prenom", donnees[1]);
                insertCommand.Parameters.AddWithValue("@email", donnees[2]);
                insertCommand.Parameters.AddWithValue("@motDePasse", donnees[3]);

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

        public bool AjouteLivre(string[] donneesL)
        {
            bool ok = false;
            MySqlConnection maConnexion = new MySqlConnection(DefinirCheminBD());
            string query = "";
            try
            {
                maConnexion.Open();
                query = "INSERT INTO abonnes (nom, prenom, titre, annee_parution, etat) values (@nom, @prenom, @titre, @annee_parution, @etat);";

                MySqlCommand insertCommand = new MySqlCommand(query, maConnexion);

                insertCommand.Parameters.AddWithValue("@nom", donneesL[0]);
                insertCommand.Parameters.AddWithValue("@prenom", donneesL[1]);
                insertCommand.Parameters.AddWithValue("@titre", donneesL[2]);
                insertCommand.Parameters.AddWithValue("@annee_parution", donneesL[3]);
                insertCommand.Parameters.AddWithValue("@etat", donneesL[3]);

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

        public string AfficheDataLivre(DataSet donneesL)
        {
            string infos = "";
            for (int i = 0; i < donneesL.Tables[0].Rows.Count; i++)
            {
                infos += donneesL.Tables[0].Rows[i]["nom"].ToString() + " | " +
                         donneesL.Tables[0].Rows[i]["prenom"].ToString() + " | " +  
                         donneesL.Tables[0].Rows[i]["email"].ToString() + " | " +
                         donneesL.Tables[0].Rows[i]["motDePasse"].ToString() + " | " + "\n";
            }
            return infos;
        }
    }
}
