using Proeflokaal_Project.Controller;
using Proeflokaal_Project.Model.Categorie;
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
    public partial class frmSubcategorieBewerken : Form
    {
        SubcategorieModel subcategorieToEdit;
        public frmSubcategorieBewerken(SubcategorieModel subcategorie)
        {
            InitializeComponent();
            subcategorieToEdit = subcategorie;
            tbx_SubcategorieNaam.Text = subcategorie.Naam;

            try
            {
                // Categorieën ophalen en in combobox zetten
                CategorieController categorieController = new CategorieController();
                List<CategorieModel> categorieën = categorieController.ReadAll();

                cbx_categorie.DataSource = categorieën;
                cbx_categorie.DisplayMember = "Naam";
                cbx_categorie.ValueMember = "CategorieId";

                // Huidige subcategorie selecteren
                cbx_categorie.SelectedValue = subcategorie.Categorie.CategorieId;
            }
            catch
            {
                // error message
                MessageBox.Show("Er is een fout opgetreden bij het ophalen van de categorieën");

                // form sluiten
                this.Close();
            }
        }

        private void btn_Terug_Click(object sender, EventArgs e)
        {
            // Form sluiten
            this.Close();
        }

        private void btn_Opslaan_Click(object sender, EventArgs e)
        {
            if (tbx_SubcategorieNaam.Text != "" && cbx_categorie.SelectedItem != null)
            {
                try
                {
                    // subcategorie model maken en vullen
                    subcategorieToEdit.Naam = tbx_SubcategorieNaam.Text;
                    subcategorieToEdit.Categorie = new CategorieModel();
                    subcategorieToEdit.Categorie.CategorieId = (int)cbx_categorie.SelectedValue;

                    // controller roepen
                    SubcategorieController subcategorieController = new SubcategorieController();
                    int rowsAffected = subcategorieController.Update(subcategorieToEdit);

                    if (rowsAffected == 1)
                    {
                        // succes message
                        MessageBox.Show("De subcategorie is succesvol bewerkt");
                        // Form sluiten
                        this.Close();
                    }
                    else
                    {
                        // error message
                        MessageBox.Show("Er is een fout opgetreden bij het bewerken van de subcategorie");
                    }
                }
                catch
                {
                    // error message
                    MessageBox.Show("Er is een fout opgetreden bij het bewerken van de subcategorie");
                }
            }
            else
            {
                // error message
                MessageBox.Show("Vul alle velden in");
            }
        }
    }
}
