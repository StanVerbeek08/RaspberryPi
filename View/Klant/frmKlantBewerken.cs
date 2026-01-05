using Proeflokaal_Project.Controller;
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
    public partial class frmKlantBewerken : Form
    {
        KlantModel klantToEdit;

        public frmKlantBewerken(KlantModel klant)
        {
            InitializeComponent();
            klantToEdit = klant;
            txtb_Voornaam.Text = klant.Voornaam;
            txtb_Tussenvoegsel.Text = klant.Tussenvoegsel;
            txtb_Achternaam.Text = klant.Achternaam;
            txtb_telefoonnummer.Text = klant.Telefoonnummer;
            txtb_Email.Text = klant.Email;
        }

        private void btn_Terug_Click(object sender, EventArgs e)
        {
            // Form sluiten
            this.Close();
        }

        private void btn_Bewerken_Click(object sender, EventArgs e)
        {
            // Controleren of verplichte velden zijn ingevuld
            if (string.IsNullOrWhiteSpace(txtb_Voornaam.Text) ||
                string.IsNullOrWhiteSpace(txtb_Achternaam.Text) ||
                string.IsNullOrWhiteSpace(txtb_telefoonnummer.Text) ||
                string.IsNullOrWhiteSpace(txtb_Email.Text))
            {
                MessageBox.Show("Niet alle verplichte velden zijn ingevuld.\nVoornaam, Achternaam, Telefoonnummer en Email zijn verplicht.");
                return;
            }

            // Klantmodel updaten met nieuwe waarden
            klantToEdit.Voornaam = txtb_Voornaam.Text;
            klantToEdit.Tussenvoegsel = txtb_Tussenvoegsel.Text; // mag leeg
            klantToEdit.Achternaam = txtb_Achternaam.Text;
            klantToEdit.Telefoonnummer = txtb_telefoonnummer.Text;
            klantToEdit.Email = txtb_Email.Text;

            try
            {
                // Controller aanmaken
                KlantController klantController = new KlantController();

                // Klant bewerken
                int rowsAffected = klantController.Update(klantToEdit);

                if (rowsAffected == 1)
                {
                    MessageBox.Show("De klant is succesvol bewerkt.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Er is een fout opgetreden bij het bewerken van de klant.");
                }
            }
            catch
            {
                MessageBox.Show("Er is een fout opgetreden bij het bewerken van de klant.");
            }
        }

    }
}
