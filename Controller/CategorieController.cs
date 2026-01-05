using Microsoft.Data.SqlClient;
using Proeflokaal_Project.Model.Categorie;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Proeflokaal_Project.Controller
{
    public class CategorieController
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringProeflokaal"].ConnectionString;
        public List<CategorieModel> ReadAll()
        {
            // Return list aanmaken
            List<CategorieModel> result = new List<CategorieModel>();
            using (var conn = new SqlConnection(connectionString))
            {
                // Sql query string maken
                string sqlQuery = "SELECT * FROM Categorie";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                {
                    // Database conncetie openen
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        // Model maken en vullen
                        CategorieModel model = new CategorieModel();
                        model.CategorieId = (int)reader["CategorieId"];
                        model.Naam = (string)reader["Naam"];
                        // Resultaat aan List toevoegen
                        result.Add(model);
                    }
                }
                // result terug geven
                return result;
            }
        }
        public int Add(CategorieModel categorie)
        {
            int rowsAffected = 0;
            using (var conn = new SqlConnection(connectionString))
            {
                // SQLQuery maken
                string sqlQuery = "INSERT INTO Categorie(Naam) " +
                                "VALUES (@Naam)";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                {
                    // Database connectie open
                    conn.Open();
                    // Parameters toevoegen aan cmd
                    cmd.Parameters.AddWithValue("@Naam", categorie.Naam);
                    // Query uitvoeren
                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }
            return rowsAffected;
        }
        public int Update(CategorieModel categorie)
        {
            int rowsAffected = 0;
            using (var conn = new SqlConnection(connectionString))
            {
                // Sql query 
                string sqlQuery = "UPDATE Categorie " +
                                "SET Naam = @Naam " +
                                "WHERE CategorieId = @CategorieId";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                {
                    // Database connectie openen
                    conn.Open();
                    // parameters toevoegen aan cmd
                    cmd.Parameters.AddWithValue("@CategorieId", categorie.CategorieId);
                    cmd.Parameters.AddWithValue("@Naam", categorie.Naam);
                    // Query uitvoeren
                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }
            return rowsAffected;
        }
        public int Delete(CategorieModel categorie)
        {
            int rowsAffected = 0;
            using (var conn = new SqlConnection(connectionString))
            {
                // sql query maken
                string sqlQuery = "DELETE FROM Categorie " +
                                "WHERE CategorieId = @CategorieId";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                {
                    // database conncetie openen
                    conn.Open();
                    // Parameters aan cmd toevoegen
                    cmd.Parameters.AddWithValue("@CategorieId", categorie.CategorieId);
                    try
                    {
                        // Query uitvoeren
                        rowsAffected = cmd.ExecuteNonQuery();
                    } 
                    catch (SqlException ex)
                    {
                        if (ex.Number == 547)
                        {
                            rowsAffected = -1;
                        } else
                        {
                            rowsAffected = 0;
                        }
                    }
                    
                }
                return rowsAffected;
            }
        }
    }
}
