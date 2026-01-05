using Proeflokaal_Project.Controller;
using Proeflokaal_Project.Model.MenuItem;
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

namespace Proeflokaal_Project.View.MenuItem
{
    public partial class frmMenuItemToevoegen : Form
    {
        public frmMenuItemToevoegen()
        {
            InitializeComponent();
        }
        public void frmMenuItemToevoegen_Load(object sender, EventArgs e)
        {
            try
            {
                // Subcategorieën ophalen voor combobox
                SubcategorieController subcategorieController = new SubcategorieController();
                List<SubcategorieModel> subcategorieën = subcategorieController.ReadAll();
                if (subcategorieën.Count > 0)
                {
                    // Subcategorieën toevoegen aan combobox
                    cbx_subcategorie.DataSource = subcategorieën;
                    cbx_subcategorie.DisplayMember = "Naam";
                    cbx_subcategorie.ValueMember = "SubcategorieId";
                }
                else
                {
                    // error message
                    MessageBox.Show("Er is geen subcategorie om de menuitem aan te koppelen, maak deze eerst aan");

                    // form sluiten
                    this.Close();
                }
            }
            catch
            {
                // error message
                MessageBox.Show("Er is een fout opgetreden bij het ophalen van alle subcategorieën");
                // Form sluiten
                this.Close();
            }
        }
        private void btn_Terug_Click(object sender, EventArgs e)
        {
            // Form sluiten
            this.Close();
        }

        private void btn_Toevoegen_Click(object sender, EventArgs e)
        {
            if (tbx_SubcategorieNaam.Text != "" && tbx_Omschrijving.Text != "" && cbx_subcategorie.SelectedValue != null)
            {
                // menu item model maken
                MenuItemModel menuItem = new MenuItemModel();
                menuItem.Naam = tbx_SubcategorieNaam.Text;
                menuItem.Omschrijving = tbx_Omschrijving.Text;
                menuItem.Subcategorie = new SubcategorieModel();
                menuItem.Subcategorie.SubcategorieId = (int)cbx_subcategorie.SelectedValue;

                try
                {
                    // Controller aanmaken en aanroepen
                    MenuItemController menuItemController = new MenuItemController();
                    int rowsAffected = menuItemController.Add(menuItem);

                    if (rowsAffected == 1)
                    {
                        // Succes message
                        MessageBox.Show("Het menu-item is succesvol aangemaakt");
                        // Form sluiten
                        this.Close();
                    }
                    else
                    {
                        // error message
                        MessageBox.Show("Er is een fout opgetreden bij het aanmaken van de menu-item");
                    }
                }
                catch
                {
                    // error message
                    MessageBox.Show("Er is een fout opgetreden bij het toevoegen van het menu-item");
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
