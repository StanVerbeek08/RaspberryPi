using Proeflokaal_Project.Model.Categorie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Configuration;
using Proeflokaal_Project.Model.MenuItem;
using Proeflokaal_Project.Model.Subcategorie;
using Microsoft.IdentityModel.Tokens;

namespace Proeflokaal_Project.Controller
{
    public class MenuItemController
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringProeflokaal"].ConnectionString;
        public List<MenuItemModel> ReadAll()
        {
            List<MenuItemModel> result = new List<MenuItemModel>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Sql query
                string sqlQuery = "SELECT s.SubcategorieId AS SubcategorieId, " +
                                "s.Naam AS SubcategorieNaam, " +
                                "m.MenuItemId AS MenuItemId, " +
                                "m.Naam AS Naam, " +
                                "m.Omschrijving AS Omschrijving " +
                                "FROM Subcategorie S " +
                                "LEFT JOIN MenuItem M " +
                                "ON m.SubcategorieId = s.SubcategorieId " +
                                "WHERE m.MenuItemId IS NOT NULL";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                {
                    // Database connectie opene
                    conn.Open();

                    // Query uitvoeren
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Door alle resultaten heen loopen
                    while (reader.Read())
                    {
                        // Menu item maken en vullen
                        MenuItemModel menuItem = new MenuItemModel();
                        menuItem.MenuItemId = (int)reader["MenuItemId"];
                        menuItem.Naam = (string)reader["Naam"];
                        menuItem.Omschrijving = (string)reader["Omschrijving"];
                        menuItem.Subcategorie = new SubcategorieModel();
                        menuItem.Subcategorie.SubcategorieId = (int)reader["SubcategorieId"];
                        menuItem.Subcategorie.Naam = (string)reader["SubcategorieNaam"];

                        // item aan lijst toevoegen
                        result.Add(menuItem);
                    }
                }
            }
            return result;
        }
        public int Add(MenuItemModel menuItem)
        {
            int rowsAffected = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // sqlquery
                string sqlQuery = "INSERT INTO Menuitem (Naam, Omschrijving, SubcategorieId)" +
                                "VALUES (@Naam, @Omschrijving, @SubcategorieId)";
                using (SqlCommand cmd = new SqlCommand(sqlQuery,conn))
                {
                    // Database connectie opene
                    conn.Open();
                    // cmd parameters toevoegen
                    cmd.Parameters.AddWithValue("@Naam", menuItem.Naam);
                    cmd.Parameters.AddWithValue("@Omschrijving", menuItem.Omschrijving);
                    cmd.Parameters.AddWithValue("@SubcategorieId", menuItem.Subcategorie.SubcategorieId);

                    // Query uitvoeren
                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }
            return rowsAffected;
        }
        public int Update(MenuItemModel menuItem)
        {
            int rowsAffected = 0;
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                // Sql query
                string sqlQuery = "UPDATE MenuItem " +
                                "SET Naam = @Naam," +
                                "Omschrijving = @Omschrijving," +
                                "SubcategorieId = @SubcategorieId " +
                                "WHERE MenuItemId = @MenuItemId";
                using (SqlCommand cmd = new SqlCommand(sqlQuery,conn))
                {
                    // Database connectie openen
                    conn.Open();
                    // parameters aan cmd toevoegen
                    cmd.Parameters.AddWithValue("@Naam", menuItem.Naam);
                    cmd.Parameters.AddWithValue("@Omschrijving", menuItem.Omschrijving);
                    cmd.Parameters.AddWithValue("@SubcategorieId", menuItem.Subcategorie.SubcategorieId);
                    cmd.Parameters.AddWithValue("@MenuItemId", menuItem.MenuItemId);

                    // query uitvoeren
                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }
            return rowsAffected;
        }
        public int Delete(MenuItemModel menuItem)
        {
            int rowsAffected = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // sql query
                string sqlQuery = "DELETE FROM MenuItem " +
                                "WHERE MenuItemId = @MenuItemId";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                {
                    // Database connectie openen
                    conn.Open();
                    // Parameters aan cmd toevoegen
                    cmd.Parameters.AddWithValue("@MenuItemId", menuItem.MenuItemId);
                    // Query uitvoeren
                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }
            return rowsAffected;
        }
    }
}
