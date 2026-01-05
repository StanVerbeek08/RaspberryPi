using Proeflokaal_Project.Controller;
using Proeflokaal_Project.Model.Klant;
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
    public partial class frmReserveringOverzicht : Form
    {
        public frmReserveringOverzicht()
        {
            InitializeComponent();
        }

        public void FillListView()
        {
            // Listview leegmaken
            lv_reservering.Items.Clear();
            try
            {
                // controller aanmaken en menu items ophalen
                ReserveringController menuItemController = new ReserveringController();
                List<ReserveringModel> reserveringen = menuItemController.ReadAll();

                // Alle menuitems in de listview zetten
                foreach (ReserveringModel reservering in reserveringen)
                {
                    // Listview item maken en data toevoegen
                    ListViewItem item = new ListViewItem(reservering.Tafel.ToString());
                    item.SubItems.Add(reservering.AantalPersonen.ToString());
                    item.SubItems.Add(reservering.Datum.ToString("dd-MM-yyyy"));
                    item.SubItems.Add(reservering.Medewerker.Voornaam);
                    item.SubItems.Add(reservering.Klant.Voornaam);


                    // Tag aan item toevoegen
                    item.Tag = reservering;
                    // Item toevoegen aan de listview
                    lv_reservering.Items.Add(item);
                }
                lv_reservering.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            catch
            {
                // error message 
                MessageBox.Show("Er is een fout opgetreden bij het ophalen van de reserveringen");
            }
        }

        private void frmReserveringOverzicht_Load(object sender, EventArgs e)
        {
            // Listview settings
            lv_reservering.FullRowSelect = true;
            lv_reservering.View = System.Windows.Forms.View.Details;
            lv_reservering.Columns.Clear();
            lv_reservering.MultiSelect = false;

            // Colom namen toevoegen
            lv_reservering.Columns.Add("Tafel");
            lv_reservering.Columns.Add("Aantal personen");
            lv_reservering.Columns.Add("Datum");
            lv_reservering.Columns.Add("Medewerker");
            lv_reservering.Columns.Add("Klant");

            // List view vullen
            FillListView();
        }

        private void btn_Terug_Click(object sender, EventArgs e)
        {
            // Form sluiten
            this.Close();
        }

        private void btn_Bewerken_Click(object sender, EventArgs e)
        {
            if (lv_reservering.SelectedItems.Count == 1)
            {
                // Categorie model maken
                ReserveringModel reservering = (ReserveringModel)lv_reservering.SelectedItems[0].Tag;
                // Bewerken form openen
                frmReserveringBewerken frmReserveringBewerken = new frmReserveringBewerken(reservering);
                frmReserveringBewerken.ShowDialog();
                // Listview verversen
                FillListView();
            }
            else
            {
                // error message
                MessageBox.Show("Er is geen reservering geselecteerd");
            }
        }

        private void btn_Toevoegen_Click(object sender, EventArgs e)
        {
            // Toevoegen form openen
            frmReserveringToevoegen frmReserveringToevoegen = new frmReserveringToevoegen();
            frmReserveringToevoegen.ShowDialog();
            // Listview verversen
            FillListView();
        }

        private void btn_Verwijderen_Click(object sender, EventArgs e)
        {
            if (lv_reservering.SelectedItems.Count == 1)
            {
                if (MessageBox.Show("Weet u zeker dat u deze reservering wilt verwijderen", "reservering verwijderen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // reservering ophalen uit listview
                    ReserveringModel reservering = (ReserveringModel)lv_reservering.SelectedItems[0].Tag;
                    // Controller aanmaken en roepen
                    ReserveringController ReserveringController = new ReserveringController();
                    int rowsAffected = ReserveringController.Delete(reservering);
                    if (rowsAffected == 1)
                    {
                        // Succes message en listview updaten
                        MessageBox.Show("Reservering is succesvol verwijderd");
                        FillListView();
                    }
                    else
                    {
                        // error message
                        MessageBox.Show("Er is een fout opgetreden bij het verwijderen van de reservering");
                    }
                }
            }
            else
            {
                // error message
                MessageBox.Show("Er is geen reservering geselecteerd");
            }
        }
    }
}
