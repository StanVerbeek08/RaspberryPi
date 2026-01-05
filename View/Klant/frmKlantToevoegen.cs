using Proeflokaal_Project.Controller;
using Proeflokaal_Project.Model.Categorie;
using Proeflokaal_Project.Model.Klant;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proeflokaal_Project.View.Klant
{
    public partial class frmKlantToevoegen : Form
    {
        public frmKlantToevoegen()
        {
            InitializeComponent();
        }

        private void btn_Terug_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Toevoegen_Click(object sender, EventArgs e)
        {
            // Controleer of alle verplichte velden zijn ingevuld
            if (string.IsNullOrWhiteSpace(txb_Voornaam.Text) ||
                string.IsNullOrWhiteSpace(txtb_Achternaam.Text) ||
                string.IsNullOrWhiteSpace(txtb_telefoonnummer.Text) ||
                string.IsNullOrWhiteSpace(txtb_Email.Text))
            {
                MessageBox.Show("Niet alle verplichte velden zijn ingevuld.\n\nVerplicht: Voornaam, Achternaam, Telefoonnummer, Email");
                return;
            }

            // Klantmodel aanmaken
            KlantModel klant = new KlantModel();
            klant.Voornaam = txb_Voornaam.Text;
            klant.Tussenvoegsel = txtb_Tussenvoegsel.Text; // MAG LEEG ZIJN
            klant.Achternaam = txtb_Achternaam.Text;
            klant.Telefoonnummer = txtb_telefoonnummer.Text;
            klant.Email = txtb_Email.Text;

            try
            {
                // Controller aanmaken
                KlantController klantController = new KlantController();

                // Klant toevoegen
                int rowsAffected = klantController.Add(klant);

                if (rowsAffected == 1)
                {
                    MessageBox.Show("De klant is succesvol toegevoegd");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Er is een fout opgetreden bij het toevoegen van de klant");
                }
            }
            catch
            {
                MessageBox.Show("Er is een fout opgetreden bij het toevoegen van de klant");
            }
        }

    }
}
