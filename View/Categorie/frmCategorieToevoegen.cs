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
    public partial class frmCategorieToevoegen : Form
    {
        public frmCategorieToevoegen()
        {
            InitializeComponent();
        }

        private void btn_Terug_Click(object sender, EventArgs e)
        {
            // Form sluiten
            this.Close();
        }

        private void btn_Toevoegen_Click(object sender, EventArgs e)
        {
            // If die checkt of alle velden zijn ingevuld
            if (tbx_CategorieNaam.Text != "")
            {
                // Categorie model maken
                CategorieModel categorie = new CategorieModel();
                categorie.Naam = tbx_CategorieNaam.Text;
                try
                {
                    // Controller aanmaken
                    CategorieController categorieController = new CategorieController();
                    // Categorie toevoegen
                    int rowsAffected = categorieController.Add(categorie);
                    if (rowsAffected == 1)
                    {
                        // Succes melding geven en form sluiten
                        MessageBox.Show("De categorie is succesvol toegevoegd");
                        this.Close();
                    }
                    else
                    {
                        // Error message
                        MessageBox.Show("Er is fout opgetreden bij het toevoegen van de categorie");
                    }
                }
                catch
                {
                    // error message
                    MessageBox.Show("Er is een fout opgetreden bij het toevoegen van de categorie");
                }
            }
            else
            {
                // Error message
                MessageBox.Show("Er is geen naam ingevuld");
            }
        }
    }
}
