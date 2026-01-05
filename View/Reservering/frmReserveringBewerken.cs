using Proeflokaal_Project.Controller;
using Proeflokaal_Project.Model.Klant;
using Proeflokaal_Project.Model.Medewerker;
using Proeflokaal_Project.Model.Reservering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proeflokaal_Project.View.Reservering
{
    public partial class frmReserveringBewerken : Form
    {
        ReserveringModel reserveringToEdit;

        public frmReserveringBewerken(ReserveringModel reservering)
        {
            InitializeComponent();
            reserveringToEdit = reservering;
            tbx_Tafel.Text = reservering.Tafel.ToString();
            tbx_Aantalpersonen.Text = reservering.AantalPersonen.ToString();
            dtp_Reservering.Text = reservering.Datum.ToString();
            //cbx_Klanten.Text = reservering.Klant.ToString();
            //cbx_Medewerkers.Text = reservering.Medewerker.ToString();
        }

        public void frmReserveringToevoegen_Load(object sender, EventArgs e)
        {

            // Alle medewerkers ophalen
            MedewerkerController controller = new MedewerkerController();
            List<MedewerkerModel> medewerkers = controller.ReadAll();

            cbx_Medewerkers.DataSource = medewerkers;
            cbx_Medewerkers.DisplayMember = "Voornaam";
            cbx_Medewerkers.ValueMember = "MedewerkerId";
            // selecteer huidige medewerker
            cbx_Medewerkers.SelectedValue = reserveringToEdit.Medewerker.MedewerkerId;


            // Alle Klanten ophalen
            KlantController klantController = new KlantController();
            List<KlantModel> klanten = klantController.ReadAll();

            cbx_Klanten.DataSource = klanten;
            cbx_Klanten.DisplayMember = "Voornaam";
            cbx_Klanten.ValueMember = "KlantId";
            // selecteer huidige klant
            cbx_Klanten.SelectedValue = reserveringToEdit.Klant.KlantId;
        }

        private void btn_Terug_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_toevoegen_Click(object sender, EventArgs e)
        {
            // Controleren of verplichte velden zijn ingevuld
            if (string.IsNullOrWhiteSpace(tbx_Tafel.Text) &&
                string.IsNullOrWhiteSpace(tbx_Aantalpersonen.Text) &&
                string.IsNullOrWhiteSpace(dtp_Reservering.Text) &&
                string.IsNullOrWhiteSpace(cbx_Klanten.Text) &&
                string.IsNullOrWhiteSpace(cbx_Medewerkers.Text))
            {
                MessageBox.Show("Niet alle verplichte velden zijn ingevuld.\nTafel, Aantal personen, Datum, Klant en Medewerker zijn verplicht.");
                return;
            }

            // Klantmodel updaten met nieuwe waarden
            reserveringToEdit.Tafel = int.Parse(tbx_Tafel.Text);
            reserveringToEdit.AantalPersonen = int.Parse(tbx_Aantalpersonen.Text);
            reserveringToEdit.Datum = dtp_Reservering.Value;
            reserveringToEdit.Medewerker.MedewerkerId = (int)cbx_Medewerkers.SelectedValue;
            reserveringToEdit.Klant.KlantId = (int)cbx_Klanten.SelectedValue;

            try
            {
                // Controller aanmaken
                ReserveringController ReserveringController = new ReserveringController();

                // Klant bewerken
                int rowsAffected = ReserveringController.Update(reserveringToEdit);

                if (rowsAffected == 1)
                {
                    MessageBox.Show("De reservering is succesvol bewerkt.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Er is een fout opgetreden bij het bewerken van de reservering.");
                }
            }
            catch
            {
                MessageBox.Show("Er is een fout opgetreden bij het bewerken van de reservering.");
            }
        }

    }
}
