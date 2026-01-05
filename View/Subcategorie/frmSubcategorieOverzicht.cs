using Microsoft.Data.SqlClient;
using Proeflokaal_Project.Controller;
using Proeflokaal_Project.Model.Subcategorie;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proeflokaal_Project.View.Subcategorie
{
    public partial class frmSubcategorie : Form
    {
        public frmSubcategorie()
        {
            InitializeComponent();
        }
        public void frmSubcategorieOverzicht_Load(object sender, EventArgs e)
        {
            // Listview settings
            lv_subcategorie.FullRowSelect = true;
            lv_subcategorie.View = System.Windows.Forms.View.Details;
            lv_subcategorie.Columns.Clear();
            lv_subcategorie.MultiSelect = false;

            // Column namen toevoegen
            lv_subcategorie.Columns.Add("Subcategorie naam");
            lv_subcategorie.Columns.Add("Categorie naam");

            // Listview vullen
            FillListView();
        }
        public void FillListView()
        {
            // Listview leegmaken
            lv_subcategorie.Items.Clear();

            try
            {
                // Controller aanmaken en oproepen
                SubcategorieController subcategorieController = new SubcategorieController();
                List<SubcategorieModel> subcategorieën = subcategorieController.ReadAll();

                // Alle subcategorieën in de listview zetten
                foreach (SubcategorieModel subcategorie in subcategorieën)
                {
                    ListViewItem item = new ListViewItem(subcategorie.Naam);
                    item.SubItems.Add(subcategorie.Categorie.Naam);

                    // Tag aan item toevoegen
                    item.Tag = subcategorie;

                    // Item aan listview toevoegen
                    lv_subcategorie.Items.Add(item);
                }
                lv_subcategorie.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            catch
            {
                MessageBox.Show("Er is een fout opgetreden bij het ophalen van de subcategorieën");
            }
        }
        private void btn_Terug_Click(object sender, EventArgs e)
        {
            // Form sluiten
            this.Close();
        }

        private void btn_Toevoegen_Click(object sender, EventArgs e)
        {
            // Toevoegen from openen
            frmSubcategorieToevoegen frmSubcategorieToevoegen = new frmSubcategorieToevoegen();
            frmSubcategorieToevoegen.ShowDialog();
            FillListView();
        }

        private void btn_Bewerken_Click(object sender, EventArgs e)
        {
            if (lv_subcategorie.SelectedItems.Count == 1)
            {
                // Subcategorie ophalen uit listview
                SubcategorieModel subcategorie = (SubcategorieModel)lv_subcategorie.SelectedItems[0].Tag;

                // Bewerken form openen
                frmSubcategorieBewerken frmSubcategorieBewerken = new frmSubcategorieBewerken(subcategorie);
                frmSubcategorieBewerken.ShowDialog();

                // List view verversen
                FillListView();
            }
            else
            {
                // error message
                MessageBox.Show("Er is geen subcategorie geselecteerd");
            }
        }

        private void btn_Verwijderen_Click(object sender, EventArgs e)
        {
            if (lv_subcategorie.SelectedItems.Count == 1)
            {
                if (MessageBox.Show("Weet u zeker dat u deze subcategorie wilt verwijderen", "Subcategorie verwijderen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    try
                    {
                        // Subcategorie ophalen uit listview
                        SubcategorieModel subcategorie = (SubcategorieModel)lv_subcategorie.SelectedItems[0].Tag;

                        // Controller aanmaken
                        SubcategorieController subcategorieController = new SubcategorieController();
                        int rowsAffected = subcategorieController.Delete(subcategorie);

                        if (rowsAffected == 1)
                        {
                            // succes message
                            MessageBox.Show("De subcategorie is succesvol verwijderd");
                            // Listview opnieuw vullen
                            FillListView();
                        }
                        else
                        {
                            // error message
                            MessageBox.Show("Er is een fout opgetreden bij het verwijderen van de subcategorie");
                        }
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Number == 547)
                        {
                            // fk error message
                            MessageBox.Show("Subcategorie kan niet worden verwijderd omdat er nog menu-items aan gekoppeld zijn");
                        }
                        else
                        {
                            // error message
                            MessageBox.Show("Er is een fout opgetreden bij het verwijderen van de subcategorie");
                        }

                    }
            }
            else
            {
                // error message
                MessageBox.Show("Er is geen subcategorie geselecteerd");
            }
        }
    }
}
