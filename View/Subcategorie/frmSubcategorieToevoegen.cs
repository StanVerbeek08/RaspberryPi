using Microsoft.Identity.Client;
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
    public partial class frmSubcategorieToevoegen : Form
    {
        public frmSubcategorieToevoegen()
        {
            InitializeComponent();
        }
        public void frmSubcategorieBewerken_Load(object sender, EventArgs e)
        {
            try
            {
                // Categorieën ophalen
                CategorieController categorieController = new CategorieController();
                List<CategorieModel> categorieën = categorieController.ReadAll();

                if (categorieën.Count > 0)
                {
                    // Data aan combobox toevoegen
                    cbx_categorie.DataSource = categorieën;
                    cbx_categorie.DisplayMember = "Naam";
                    cbx_categorie.ValueMember = "CategorieId";
                }
                else
                {
                    // error message
                    MessageBox.Show("Er zijn is geen categorie om een subcategorie aan te koppelen, maak deze eerst aan");
                    // form sluiten
                    this.Close();
                }
            }
            catch
            {
                // error message
                MessageBox.Show("Er is een fout opgetreden bij het ophalen van de categorieën");

                // form sluiten
                this.Close();
            }

        }
        private void btn_Toevoegen_Click(object sender, EventArgs e)
        {
            if (tbx_SubcategorieNaam.Text != "" && cbx_categorie.SelectedItem != null)
            {
                try
                {
                    // subcategorie model aanmaken
                    SubcategorieModel subcategorie = new SubcategorieModel();
                    subcategorie.Naam = tbx_SubcategorieNaam.Text;
                    subcategorie.Categorie = new CategorieModel();
                    subcategorie.Categorie.CategorieId = (int)cbx_categorie.SelectedValue;

                    // controller aanroepen
                    SubcategorieController subcategorieController = new SubcategorieController();
                    int rowsAffected = subcategorieController.Add(subcategorie);
                    if (rowsAffected == 1)
                    {
                        // succes message
                        MessageBox.Show("Subcategorie is succesvol toegvoegd");
                        // form sluiten
                        this.Close();
                    }
                    else
                    {
                        // error message
                        MessageBox.Show("Er is een fout opgetreden bij het toevoegen van de subcategorie");
                    }
                }
                catch
                {
                    // error message
                    MessageBox.Show("Er is een fout opgetreden bij het toevoegen van de subcategorie");
                }
            }
            else
            {
                // error message
                MessageBox.Show("Vul alle velden in");
            }
        }

        private void btn_Terug_Click(object sender, EventArgs e)
        {
            // form sluiten
            this.Close();
        }
    }
}
