using Microsoft.Data.SqlClient;
using Proeflokaal_Project.Model.Medewerker;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proeflokaal_Project.Controller
{
    public class MedewerkerController
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringProeflokaal"].ConnectionString;

        public List<MedewerkerModel> ReadAll()
        {
            List<MedewerkerModel> result = new List<MedewerkerModel>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Ophalen van alle medewerkers
                string sqlQuery = "SELECT * FROM Medewerker";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                {
                    conn.Open();
                    // sql query uitvoeren en door resultaar heen loopen
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        // Medewerker model maken en vullen met data
                        MedewerkerModel medewerker = new MedewerkerModel();
                        medewerker.MedewerkerId = (int)reader["MedewerkerId"];
                        medewerker.Voornaam = (string)reader["Voornaam"];
                        medewerker.Tussenvoegsel = (string)reader["Tussenvoegsel"];
                        medewerker.Achternaam = (string)reader["Achternaam"];
                        medewerker.Gebruikersnaam = (string)reader["Gebruikersnaam"];
                        medewerker.Rol = (byte)reader["Rol"];

                        // Medewerker aan de medewerker lijst toevoegen
                        result.Add(medewerker);
                    }
                }
            }
            return result;
        }
        public int Add(MedewerkerModel medewerker)
        {
            int rowsAffected = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // medewerker toevoegen
                string sqlQuery = "INSERT INTO Medewerker (Voornaam,Tussenvoegsel,Achternaam,Gebruikersnaam,Rol) " +
                                "VALUES (@Voornaam,@TussenVoegsel,@Achternaam,@Gebruikersnaam,@Rol)";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn)) 
                { 
                    conn.Open();
                    // Parameters aan cmd toevoegen
                    cmd.Parameters.AddWithValue("@Voornaam", medewerker.Voornaam);
                    cmd.Parameters.AddWithValue("@Tussenvoegsel", medewerker.Tussenvoegsel);
                    cmd.Parameters.AddWithValue("@Achternaam", medewerker.Achternaam);
                    cmd.Parameters.AddWithValue("@Gebruikersnaam", medewerker.Gebruikersnaam);
                    cmd.Parameters.AddWithValue("@Rol", medewerker.Rol);
                    // Query uitvoeren als int rowsaffected
                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }
            return rowsAffected;
        }
        public int Update(MedewerkerModel medewerker)
        {
            int rowsAffected = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // update query voor een medewerker
                string sqlQuery = "UPDATE Medewerker " +
                                "SET Voornaam = @Voornaam, " +
                                "Tussenvoegsel = @Tussenvoegsel " +
                                "Achternaam = @Achternaam " +
                                "Gebruikersnaam = @Gebruikersnaam " +
                                "Rol = @Rol " +
                                "WHERE MedewerkerId = @MedewerkerId";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                {
                    conn.Open();
                    // Parameters aan cmd toevoegen
                    cmd.Parameters.AddWithValue("@Voornaam", medewerker.Voornaam);
                    cmd.Parameters.AddWithValue("@Tussenvoegsel", medewerker.Tussenvoegsel);
                    cmd.Parameters.AddWithValue("@Achternaam", medewerker.Achternaam);
                    cmd.Parameters.AddWithValue("@Gebruikersnaam", medewerker.Gebruikersnaam);
                    cmd.Parameters.AddWithValue("@Rol", medewerker.Rol);
                    cmd.Parameters.AddWithValue("@MedewerkerId", medewerker.MedewerkerId);
                    // Query uitvoeren en als int rowsaffected returne
                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }
            return rowsAffected;
        }
        public int Delete(MedewerkerModel medewerker)
        {
            int rowsAffected = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Query op medewerker te verwijderen
                string sqlQuery = "DELETE FROM Medewerker " +
                                "WHERE MedewerkerId = @MedewerkerId";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                {
                    conn.Open();
                    // Parameter aan cmd toevoegen
                    cmd.Parameters.AddWithValue("@MedewerkerId", medewerker.MedewerkerId);
                    // Query uitvoeren en int rowsAffected return
                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }
            return rowsAffected;
        }
    }
}
