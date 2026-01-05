using Microsoft.Data.SqlClient;
using Proeflokaal_Project.Model.Categorie;
using Proeflokaal_Project.Model.Klant;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proeflokaal_Project.Controller
{
    public class KlantController
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringProeflokaal"].ConnectionString;

        public List<KlantModel> ReadAll()
        {
            // Return list aanmaken
            List<KlantModel> result = new List<KlantModel>();
            using (var conn = new SqlConnection(connectionString))
            {
                // Sql query string maken
                string sqlQuery = "SELECT * FROM Klant";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                {
                    // Database conncetie openen
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        // Model maken en vullen
                        KlantModel model = new KlantModel();
                        model.KlantId = (int)reader["KlantId"];
                        model.Voornaam = (string)reader["Voornaam"];
                        model.Tussenvoegsel = (string)reader["Tussenvoegsel"];
                        model.Achternaam = (string)reader["Achternaam"];
                        model.Telefoonnummer = (string)reader["Telefoonnummer"];
                        model.Email = (string)reader["Email"];
                        // Resultaat aan List toevoegen
                        result.Add(model);
                    }
                }
                // result terug geven
                return result;
            }
        }
        public int Add(KlantModel klant)
        {
            int rowsAffected = 0;

            using (var conn = new SqlConnection(connectionString))
            {
                string sqlQuery = "INSERT INTO Klant (Voornaam, Tussenvoegsel, Achternaam, Telefoonnummer, Email) " +
                                  "VALUES (@Voornaam, @Tussenvoegsel, @Achternaam, @Telefoonnummer, @Email)";

                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                {
                    conn.Open();

                    cmd.Parameters.AddWithValue("@Voornaam", klant.Voornaam);
                    cmd.Parameters.AddWithValue("@Tussenvoegsel", klant.Tussenvoegsel);
                    cmd.Parameters.AddWithValue("@Achternaam", klant.Achternaam);
                    cmd.Parameters.AddWithValue("@Telefoonnummer", klant.Telefoonnummer);
                    cmd.Parameters.AddWithValue("@Email", klant.Email);

                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }

            return rowsAffected;
        }
        public int Update(KlantModel klant)
        {
            int rowsAffected = 0;

            using (var conn = new SqlConnection(connectionString))
            {
                string sqlQuery = "UPDATE Klant " +
                                  "SET Voornaam = @Voornaam, " +
                                  "Tussenvoegsel = @Tussenvoegsel, " +
                                  "Achternaam = @Achternaam, " +
                                  "Telefoonnummer = @Telefoonnummer, " +
                                  "Email = @Email " +
                                  "WHERE KlantId = @KlantId";

                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                {
                    conn.Open();

                    cmd.Parameters.AddWithValue("@KlantId", klant.KlantId);
                    cmd.Parameters.AddWithValue("@Voornaam", klant.Voornaam);
                    cmd.Parameters.AddWithValue("@Tussenvoegsel", klant.Tussenvoegsel.ToString());
                    cmd.Parameters.AddWithValue("@Achternaam", klant.Achternaam);
                    cmd.Parameters.AddWithValue("@Telefoonnummer", klant.Telefoonnummer);
                    cmd.Parameters.AddWithValue("@Email", klant.Email);

                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }

            return rowsAffected;
        }
        public int Delete(KlantModel klant)
        {
            int rowsAffected = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sqlQuery = "DELETE FROM Klant " +
                                "WHERE KlantId = @KlantId";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                {
                    // database conncetie openen
                    conn.Open();
                    // parameters aan cmd toevoegen
                    cmd.Parameters.AddWithValue("@KlantId", klant.KlantId);
                    // query uitvoeren
                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }

            return rowsAffected;
        }
    }
}



































