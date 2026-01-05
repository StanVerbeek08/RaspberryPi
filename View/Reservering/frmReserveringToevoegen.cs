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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proeflokaal_Project.View.Reservering
{
    public partial class frmReserveringToevoegen : Form
    {
        public frmReserveringToevoegen()
        {
            InitializeComponent();
        }

        public void frmReserveringToevoegen_Load(object sender, EventArgs e)
        {
            
            // Alle medewerkers ophalen
            MedewerkerController controller = new MedewerkerController();
            List<MedewerkerModel> medewerkers = controller.ReadAll();

            cbx_Medewerkers.DataSource = medewerkers;
            cbx_Medewerkers.DisplayMember = "Voornaam";
            cbx_Medewerkers.ValueMember = "MedewerkerId";

            // Alle Klanten ophalen
            KlantController klantController = new KlantController();
            List<KlantModel> klanten = klantController.ReadAll();

            cbx_Klanten.DataSource = klanten;
            cbx_Klanten.DisplayMember = "Voornaam";
            cbx_Klanten.ValueMember = "KlantId";
            
        }
        private void btn_Terug_Click(object sender, EventArgs e)
        {
            // Form sluiten
            this.Close();
        }

        private void btn_Toevoegen_Click(object sender, EventArgs e)
        {
            // Controleer of alle verplichte velden zijn ingevuld
            if (tbx_Tafel.Text != "" && tbx_Aantalpersonen.Text != "" && dtp_Reservering.Text != "" && cbx_Medewerkers.SelectedValue != null)
            {
                // Reserveringmodel aanmaken
                ReserveringModel reservering = new ReserveringModel();
                try
                {
                    reservering.Tafel = Convert.ToInt32(tbx_Tafel.Text);
                    reservering.AantalPersonen = Convert.ToInt32(tbx_Aantalpersonen.Text);
                }
                catch
                {
                    MessageBox.Show("vul een geldig getal in bij 'Tafel & 'Aantal personen' ");
                    return;
                }
                try
                {
                    reservering.Datum = dtp_Reservering.Value;
                    reservering.Medewerker = new MedewerkerModel();
                    reservering.Medewerker.MedewerkerId = (int)cbx_Medewerkers.SelectedValue;
                    reservering.Klant = new KlantModel();
                    reservering.Klant.KlantId = (int)cbx_Klanten.SelectedValue;

                    // Controller aanmaken
                    ReserveringController reserveringController = new ReserveringController();

                    // Reservering toevoegen
                    int rowsAffected = reserveringController.Add(reservering);

                    if (rowsAffected == 1)
                    {
                        MessageBox.Show("De reservering is succesvol toegevoegd");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Er is een fout opgetreden bij het toevoegen van de reservering");
                    }
                }
                catch
                {
                MessageBox.Show("Er is een fout opgetreden bij het toevoegen van de reservering");
                }
            }
            else
            {
                MessageBox.Show("Niet alle verplichte velden zijn ingevuld.\n\nVerplicht: Tafel, Aantal personen, Datum, Medewerker");
            }

            
        }
    }
}
