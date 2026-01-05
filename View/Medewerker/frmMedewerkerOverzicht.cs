using Proeflokaal_Project.Controller;
using Proeflokaal_Project.Model.Medewerker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Proeflokaal_Project.View.Medewerker
{
    public partial class frmMedewerkerOverzicht : Form
    {
        public frmMedewerkerOverzicht()
        {
            InitializeComponent();
        }
        public void frmMedewerkerOverzicht_Load(object sender, EventArgs e)
        {
            // Listview settings
            lv_medewerker.FullRowSelect = true;
            lv_medewerker.View = System.Windows.Forms.View.Details;
            lv_medewerker.Columns.Clear();
            lv_medewerker.MultiSelect = false;

            // Column namen toevoegen
            lv_medewerker.Columns.Add("Voornaam");
            lv_medewerker.Columns.Add("Tussenvoegsel");
            lv_medewerker.Columns.Add("Achternaam");
            lv_medewerker.Columns.Add("Gebruikersnaam");
            lv_medewerker.Columns.Add("Rol");

            // Listview vullen
            FillListView();
        }
        public void FillListView()
        {
            lv_medewerker.Items.Clear();

            try
            {
                // Alle medewerkers ophalen
                MedewerkerController medewerkerController = new MedewerkerController();
                List<MedewerkerModel> medewerkers = medewerkerController.ReadAll();

                // Alle medewerkers in het overzicht zetten
                foreach (MedewerkerModel medewerker in medewerkers)
                {
                    // Listview item aanmaken en vullen met medewerker datum
                    ListViewItem item = new ListViewItem(medewerker.Voornaam);
                    item.SubItems.Add(medewerker.Tussenvoegsel);
                    item.SubItems.Add(medewerker.Achternaam);
                    item.SubItems.Add(medewerker.Gebruikersnaam);
                    item.SubItems.Add(medewerker.Rol.ToString());

                    item.Tag = medewerker;

                    // toevoegen aan listview
                    lv_medewerker.Items.Add(item);
                }
                lv_medewerker.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            }
            catch
            {
                // Fout melding
                MessageBox.Show("Er is een fout opgetreden bij het ophalen van de medewerkers");
            }
        }
        private void btn_Terug_Click(object sender, EventArgs e)
        {
            // form sluiten
            this.Close();
        }
    }
}
