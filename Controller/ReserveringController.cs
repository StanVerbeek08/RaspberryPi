using Microsoft.Data.SqlClient;
using Proeflokaal_Project.Model.Klant;
using Proeflokaal_Project.Model.Medewerker;
using Proeflokaal_Project.Model.Reservering;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proeflokaal_Project.Controller
{
    public class ReserveringController
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringProeflokaal"].ConnectionString;

        public List<ReserveringModel> ReadAll()
        {
            // Return list aanmaken
            List<ReserveringModel> result = new List<ReserveringModel>();
            using (var conn = new SqlConnection(connectionString))
            {
                // Sql query string maken
                string sqlQuery = "SELECT r.ReserveringId AS ReserveringId," +
                    "r.Tafel AS Tafel, " +
                    "r.AantalPersonen AS AantalPersonen, " +
                    "r.Datum AS Datum, " +
                    "k.Voornaam AS KlantVoornaam, " +
                    "k.KlantId AS KlantId, " +
                    "m.Voornaam AS MedewerkerVoornaam, " +
                    "m.MedewerkerId AS MedewerkerId " +
                    "FROM Reservering r " +
                    "LEFT JOIN Klant k " +
                    "ON r.KlantId = k.KlantID " +
                    "LEFT JOIN Medewerker m " +
                    "ON r.MedewerkerId = m.MedewerkerId";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                {
                    // Database conncetie openen
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        // Model maken en vullen
                        ReserveringModel reservering = new ReserveringModel();
                        reservering.ReserveringId = (int)reader["ReserveringId"];
                        reservering.Tafel = (int)reader["Tafel"];
                        reservering.AantalPersonen = (int)reader["AantalPersonen"];
                        reservering.Datum = (DateTime)reader["Datum"];
                        reservering.Klant = new KlantModel();
                        reservering.Klant.Voornaam = (string)reader["KlantVoornaam"];
                        reservering.Klant.KlantId = (int)reader["KlantId"];
                        reservering.Medewerker = new MedewerkerModel();
                        reservering.Medewerker.Voornaam = (string)reader["MedewerkerVoornaam"];
                        reservering.Medewerker.MedewerkerId = (int)reader["MedewerkerId"];
                        // Resultaat aan List toevoegen
                        result.Add(reservering);
                    }
                }
                // result terug geven
                return result;
            }
        }
        public int Add(ReserveringModel reservering)
        {
            int rowsAffected = 0;

            using (var conn = new SqlConnection(connectionString))
            {
                string sqlQuery = "INSERT INTO Reservering (Tafel, AantalPersonen, Datum, MedewerkerId, KlantId) " +
                                  "VALUES (@Tafel, @AantalPersonen, @Datum, @MedewerkerId, @KlantId)";

                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                {
                    conn.Open();
                    // Parameters aan cmd toevoegen
                    cmd.Parameters.AddWithValue("@Tafel", reservering.Tafel);
                    cmd.Parameters.AddWithValue("@AantalPersonen", reservering.AantalPersonen);
                    cmd.Parameters.AddWithValue("@Datum", reservering.Datum);
                    cmd.Parameters.AddWithValue("@MedewerkerId", reservering.Medewerker.MedewerkerId);
                    cmd.Parameters.AddWithValue("@KlantId", reservering.Klant.KlantId);

                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }

            return rowsAffected;
        }
        public int Update(ReserveringModel reservering)
        {
            int rowsAffected = 0;

            using (var conn = new SqlConnection(connectionString))
            {
                string sqlQuery = "UPDATE Reservering " +
                                  "SET Tafel = @Tafel, " +
                                  "AantalPersonen = @AantalPersonen, " +
                                  "Datum = @Datum, " +
                                  "KlantId = @KlantId, " +
                                  "MedewerkerId = @MedewerkerId " +
                                  "WHERE ReserveringId = @ReserveringId";

                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                {
                    conn.Open();

                    cmd.Parameters.AddWithValue("@ReserveringId", reservering.ReserveringId);
                    cmd.Parameters.AddWithValue("@Tafel", reservering.Tafel);
                    cmd.Parameters.AddWithValue("@AantalPersonen", reservering.AantalPersonen);
                    cmd.Parameters.AddWithValue("@Datum", reservering.Datum);
                    cmd.Parameters.AddWithValue("@KlantId", reservering.Klant.KlantId);
                    cmd.Parameters.AddWithValue("@MedewerkerId", reservering.Medewerker.MedewerkerId);

                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }
            return rowsAffected;
        }
        public int Delete(ReserveringModel reservering)
        {
            int rowsAffected = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sqlQuery = "DELETE FROM Reservering " +
                                "WHERE ReserveringId = @ReserveringId";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                {
                    // database conncetie openen
                    conn.Open();
                    // parameters aan cmd toevoegen
                    cmd.Parameters.AddWithValue("@ReserveringId", reservering.ReserveringId);
                    // query uitvoeren
                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }

            return rowsAffected;
        }
    }
}
