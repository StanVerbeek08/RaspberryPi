using Proeflokaal_Project.Controller;
using Proeflokaal_Project.Model.Categorie;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 
namespace Proeflokaal_Project.View.Categorie
{
    public partial class frmCategorieOverzicht : Form
    {
        public frmCategorieOverzicht()
        {
            InitializeComponent();
        }

        private void btn_Terug_Click(object sender, EventArgs e)
        {
            // Form sluiten
            this.Close();
        }

        private void frmCategorieOverzicht_Load(object sender, EventArgs e)
        {
            // Listview settings
            lv_categorie.FullRowSelect = true;
            lv_categorie.View = System.Windows.Forms.View.Details;
            lv_categorie.Columns.Clear();
            lv_categorie.MultiSelect = false;

            // Column namen toevoegen
            lv_categorie.Columns.Add("Naam");

            // Listview vullen
            FillListView();
        }
        public void FillListView()
        {
            // Listview leegmaken
            lv_categorie.Items.Clear();

            try
            {
                // Controller aanmaken een categorieën ophalen
                CategorieController controller = new CategorieController();
                List<CategorieModel> categorieën = controller.ReadAll();

                // Foreach die alle categorieën in de lv zet
                foreach (CategorieModel categorie in categorieën)
                {
                    // Item vullen
                    ListViewItem item = new ListViewItem(categorie.Naam);
                    // Tag toevoegen
                    item.Tag = categorie;
                    // Item toeveogen aan Listview
                    lv_categorie.Items.Add(item);
                }
                lv_categorie.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);  
            }
            catch
            {
                // Error message
                MessageBox.Show("Er is een fout opgetreden bij het ophalen van de categorieën");
            }
        }

        private void btn_Toevoegen_Click(object sender, EventArgs e)
        {
            // Toevoegen form openen
            frmCategorieToevoegen frmCategorieToevoegen = new frmCategorieToevoegen();
            frmCategorieToevoegen.ShowDialog();
            // Listview verversen
            FillListView();
        }

        private void btn_Bewerken_Click(object sender, EventArgs e)
        {
            if (lv_categorie.SelectedItems.Count == 1)
            {
                // Categorie model maken
                CategorieModel categorie = (CategorieModel)lv_categorie.SelectedItems[0].Tag;
                // Bewerken form openen
                frmCategorieBewerken frmCategorieBewerken = new frmCategorieBewerken(categorie);
                frmCategorieBewerken.ShowDialog();
                // Listview verversen
                FillListView();
            }
            else
            {
                // error message
                MessageBox.Show("Er is geen categorie geselecteerd");
            }

        }

        private void btn_Verwijderen_Click(object sender, EventArgs e)
        {
            if (lv_categorie.SelectedItems.Count == 1)
            {
                if (MessageBox.Show("Weet u zeker dat u deze categorie wilt verwijderen", "Categorie verwijderen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Categorie ophalen uit listview
                    CategorieModel categorie = (CategorieModel)lv_categorie.SelectedItems[0].Tag;
                    // Controller aanmaken en roepen
                    CategorieController categorieController = new CategorieController();
                    int rowsAffected = categorieController.Delete(categorie);
                    if (rowsAffected == 1)
                    {
                        // Succes message en listview updaten
                        MessageBox.Show("Categorie is succesvol verwijderd");
                        FillListView();
                    }
                    else if (rowsAffected == -1)
                    {
                        MessageBox.Show("De categorie kan niet worden verwijderd omdat er nog subcategorieën aan zijn gekoppeld");
                    }
                    else
                    {
                        // error message
                        MessageBox.Show("Er is een fout opgetreden bij het verwijderen van de categorie");
                    }
                }
            }
            else
            {
                // error message
                MessageBox.Show("Er is geen categorie geselecteerd");
            }
        }
    }
}
