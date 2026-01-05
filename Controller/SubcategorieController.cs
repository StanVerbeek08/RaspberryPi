using Microsoft.Data.SqlClient;
using Proeflokaal_Project.Model.Categorie;
using Proeflokaal_Project.Model.Subcategorie;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Proeflokaal_Project.Controller
{
    public class SubcategorieController
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringProeflokaal"].ConnectionString;
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<SubcategorieModel> ReadAll()
        {
            // List aanmaken
            List<SubcategorieModel> result = new List<SubcategorieModel>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Join met categorietabel om ook categerieobject goed te kunnen vullen.
                string sqlQuery = "SELECT c.CategorieId AS CategorieId, " +
                                "c.Naam AS CategorieNaam, " +
                                "s.SubcategorieId AS SubcategorieId, " +
                                "s.Naam AS SubcategorieNaam " +
                                "FROM Categorie C " +
                                "LEFT JOIN Subcategorie S " +
                                "ON C.CategorieId = s.CategorieId " +
                                "WHERE SubcategorieId IS NOT NULL";
                using(SqlCommand cmd = new SqlCommand(sqlQuery,conn))
                {
                    // Database connectie openen
                    conn.Open();

                    // Datareader aanmaken
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        // Model aanmaken
                        SubcategorieModel subcategorie = new SubcategorieModel();

                        // Model vullen met data
                        subcategorie.SubcategorieId = (int)reader["SubcategorieId"];
                        subcategorie.Naam = (string)reader["SubcategorieNaam"];
                        subcategorie.Categorie = new CategorieModel();
                        subcategorie.Categorie.CategorieId = (int)reader["CategorieId"];
                        subcategorie.Categorie.Naam = (string)reader["CategorieNaam"];

                        // Subcategorie toevoegen aan list
                        result.Add(subcategorie);
                    }
                }
            }
            // Resultaat terug geven
            return result;
        }
        public int Add(SubcategorieModel subcategorie)
        {
            int rowsAffected = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Sql query
                string sqlQuery = "INSERT INTO Subcategorie (Naam,CategorieId) " +
                                "VALUES (@Naam, @CategorieId)";
                using (SqlCommand cmd = new SqlCommand(@sqlQuery, conn))
                {
                    // Database connectie openen
                    conn.Open();
                    // Parameters toevoegen
                    cmd.Parameters.AddWithValue("@Naam", subcategorie.Naam);
                    cmd.Parameters.AddWithValue("@CategorieId", subcategorie.Categorie.CategorieId);

                    // Query uivoeren
                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }
            return rowsAffected;
        }
        public int Update(SubcategorieModel subcategorie)
        {
            int rowsAffected = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Sql query
                string sqlQuery = "UPDATE Subcategorie " +
                                "SET Naam = @Naam, CategorieId = @CategorieId " +
                                "WHERE SubcategorieId = @SubcategorieId";
                using (SqlCommand cmd = new SqlCommand(@sqlQuery, conn))
                {
                    // DB conn openen
                    conn.Open();

                    // parameters aan cmd toevoegen
                    cmd.Parameters.AddWithValue("@Naam", subcategorie.Naam);
                    cmd.Parameters.AddWithValue("@CategorieId", subcategorie.Categorie.CategorieId);
                    cmd.Parameters.AddWithValue("@SubcategorieId", subcategorie.SubcategorieId);
                    
                    // Query uitvoeren
                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }
            return rowsAffected;
        }
        public int Delete(SubcategorieModel subcategorie)
        {
            int rowsAffected = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // SqlQuery
                string sqlQuery = "DELETE FROM Subcategorie " +
                                "WHERE SubcategorieId = @SubcategorieId";
                using(SqlCommand cmd  = new SqlCommand(@sqlQuery, conn))
                {
                    // Database connectie
                    conn.Open();

                    // cmd parameters toevoegen
                    cmd.Parameters.AddWithValue("@SubcategorieId", subcategorie.SubcategorieId);

                    // Qeury uitvoeren
                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }
            return rowsAffected;
        }
    }
}
