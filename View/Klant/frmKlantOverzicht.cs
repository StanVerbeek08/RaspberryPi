using Proeflokaal_Project.Controller;
using Proeflokaal_Project.Model.Categorie;
using Proeflokaal_Project.Model.Klant;
using Proeflokaal_Project.Model.MenuItem;
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
    public partial class frmKlantOverzicht : Form
    {
        public frmKlantOverzicht()
        {
            InitializeComponent();
        }

        private void btn_Terug_Click(object sender, EventArgs e)
        {
            // Form sluiten
            this.Close();
        }

        private void lv_klant_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void FillListView()
        {
            // Listview leegmaken
            lv_klanten.Items.Clear();
            try
            {
                // controller aanmaken en menu items ophalen
                KlantController menuItemController = new KlantController();
                List<KlantModel> menuItems = menuItemController.ReadAll();

                // Alle menuitems in de listview zetten
                foreach (KlantModel menutItem in menuItems)
                {
                    // Listview item maken en data toevoegen
                    ListViewItem item = new ListViewItem(menutItem.Voornaam);
                    item.SubItems.Add(menutItem.Tussenvoegsel);
                    item.SubItems.Add(menutItem.Achternaam);
                    item.SubItems.Add(menutItem.Telefoonnummer);
                    item.SubItems.Add(menutItem.Email);

                    // Tag aan item toevoegen
                    item.Tag = menutItem;
                    // Item toevoegen aan de listview
                    lv_klanten.Items.Add(item);
                }
                lv_klanten.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            catch
            {
                // error message 
                MessageBox.Show("Er is een fout opgetreden bij het ophalen van de klanten");
            }
        }

        private void frmKlantOverzicht_Load(object sender, EventArgs e)
        {
            // Listview settings
            lv_klanten.FullRowSelect = true;
            lv_klanten.View = System.Windows.Forms.View.Details;
            lv_klanten.Columns.Clear();
            lv_klanten.MultiSelect = false;

            // Colom namen toevoegen
            lv_klanten.Columns.Add("Voornaam");
            lv_klanten.Columns.Add("Tussenvoegsel");
            lv_klanten.Columns.Add("Achternaam");
            lv_klanten.Columns.Add("Telefoonnummer");
            lv_klanten.Columns.Add("Email");

            // List view vullen
            FillListView();
        }

        private void btn_Verwijderen_Click(object sender, EventArgs e)
        {
            if (lv_klanten.SelectedItems.Count == 1)
            {
                if (MessageBox.Show("Weet u zeker dat u deze klant wilt verwijderen", "klant verwijderen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // klant ophalen uit listview
                    KlantModel klant = (KlantModel)lv_klanten.SelectedItems[0].Tag;
                    // Controller aanmaken en roepen
                    KlantController klantController = new KlantController();
                    int rowsAffected = klantController.Delete(klant);
                    if (rowsAffected == 1)
                    {
                        // Succes message en listview updaten
                        MessageBox.Show("Klant is succesvol verwijderd");
                        FillListView();
                    }
                    else
                    {
                        // error message
                        MessageBox.Show("Er is een fout opgetreden bij het verwijderen van de klant");
                    }
                }
            }
            else
            {
                // error message
                MessageBox.Show("Er is geen klant geselecteerd");
            }
        }

        private void btn_Toevoegen_Click(object sender, EventArgs e)
        {
            // Toevoegen form openen
            frmKlantToevoegen frmKlantToevoegen = new frmKlantToevoegen();
            frmKlantToevoegen.ShowDialog();
            // Listview verversen
            FillListView();
        }

        private void btn_Bewerken_Click(object sender, EventArgs e)
        {
            if (lv_klanten.SelectedItems.Count == 1)
            {
                // Categorie model maken
                KlantModel klant = (KlantModel)lv_klanten.SelectedItems[0].Tag;
                // Bewerken form openen
                frmKlantBewerken frmKlantBewerken = new frmKlantBewerken(klant);
                frmKlantBewerken.ShowDialog();
                // Listview verversen
                FillListView();
            }
            else
            {
                // error message
                MessageBox.Show("Er is geen klant geselecteerd");
            }
        }
    }
}
