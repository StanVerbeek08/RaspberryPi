using Proeflokaal_Project.Controller;
using Proeflokaal_Project.Model.Categorie;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proeflokaal_Project.View.Categorie
{
    public partial class frmCategorieBewerken : Form
    {
        CategorieModel categorieToEdit;
        public frmCategorieBewerken(CategorieModel categorie)
        {
            InitializeComponent();

            categorieToEdit = categorie;
            tbx_CategorieNaam.Text = categorie.Naam;
        }

        private void btn_Terug_Click(object sender, EventArgs e)
        {
            // form sluiten
            this.Close();
        }

        private void btn_Opslaan_Click(object sender, EventArgs e)
        {
            if (tbx_CategorieNaam.Text != "")
            {
                // categorie vullen met nieuwe waarde
                categorieToEdit.Naam = tbx_CategorieNaam.Text;
                try
                {
                    // controller aanmaken en aanroepen
                    CategorieController categorieController = new CategorieController();
                    int rowsAffected = categorieController.Update(categorieToEdit);
                    // Checken of query succesvol is
                    if (rowsAffected == 1)
                    {
                        // Succes message en form sluiten
                        MessageBox.Show("De categorie is succesvol aangepast");
                        this.Close();
                    }
                    else
                    {
                        // error message
                        MessageBox.Show("Er is een fout opgetreden bij het bewerken van de categorie");
                    }
                }
                catch
                {
                    // error message
                    MessageBox.Show("Er is een fout opgetreden bij het bewerken van de categorie");
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
