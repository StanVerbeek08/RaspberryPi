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
    public partial class frmMenuItemBewerken : Form
    {
        public MenuItemModel menuItemToEdit;
        public frmMenuItemBewerken(MenuItemModel menuItem)
        {
            InitializeComponent();
            // Menu item data in velden zijn
            menuItemToEdit = menuItem;
            tbx_MenuItemNaam.Text = menuItem.Naam;
            tbx_Omschrijving.Text = menuItem.Omschrijving;

            try
            {
                // combobox data ophalen
                SubcategorieController subcategorieController = new SubcategorieController();
                List<SubcategorieModel> categorieën = subcategorieController.ReadAll();

                // data in combobox zetten
                cbx_categorie.DataSource = categorieën;
                cbx_categorie.DisplayMember = "Naam";
                //cbx_categorie.ValueMember = "SubcategorieId";
                cbx_categorie.SelectedItem = menuItem.Subcategorie;
            }
            catch
            {
                // error message
                MessageBox.Show("Er is een fout opgetreden bij het ophalen van de subcategorieën");
                // form sluiten
                this.Close();
            }
        }
        private void btn_Terug_Click(object sender, EventArgs e)
        {
            // Form sluiten
            this.Close();
        }

        private void btn_Opslaan_Click(object sender, EventArgs e)
        {
            if (tbx_MenuItemNaam.Text != "" && tbx_Omschrijving.Text != "" && cbx_categorie.SelectedValue != null)
            {
                // menuitem to edit vullen met nieuwe data
                menuItemToEdit.Naam = tbx_MenuItemNaam.Text;
                menuItemToEdit.Omschrijving = tbx_Omschrijving.Text;
                menuItemToEdit.Subcategorie = (SubcategorieModel)cbx_categorie.SelectedItem;

                // Controller aanroepen
                MenuItemController menuItemController = new MenuItemController();
                int rowsAffected = menuItemController.Update(menuItemToEdit);
                // Rowaffected = 1 betekent dat er precies 1 rij veranderd is, wat je dus wil 
                if (rowsAffected == 1)
                {
                    // succes message
                    MessageBox.Show("Het menu-item is succesvol aangepast");
                    // Form sluiten
                    this.Close();
                }
                else
                {
                    // error message
                    MessageBox.Show("Er is een fout opgetreden bij het bewerken van het menu-item");
                }
            }
            else
            {
                // error message
                MessageBox.Show("Vul alle velden in");
            }
        }

        private void frmMenuItemBewerken_Load(object sender, EventArgs e)
        {

        }
    }
}
