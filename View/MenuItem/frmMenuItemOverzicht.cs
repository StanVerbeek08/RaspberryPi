using Proeflokaal_Project.Controller;
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

namespace Proeflokaal_Project.View.MenuItem
{
    public partial class frmMenuItemOverzicht : Form
    {
        public frmMenuItemOverzicht()
        {
            InitializeComponent();
        }
        public void frmMenuItemOverzicht_Load(object sender, EventArgs e)
        {
            // Listview settings
            lv_menuitem.FullRowSelect = true;
            lv_menuitem.View = System.Windows.Forms.View.Details;
            lv_menuitem.Columns.Clear();
            lv_menuitem.MultiSelect = false;

            // Column namen toevoegen
            lv_menuitem.Columns.Add("Subcategorie naam");
            lv_menuitem.Columns.Add("Menu-item naam");
            lv_menuitem.Columns.Add("Omschrijving");

            // Listview vullen
            FillListView();
        }
        public void FillListView()
        {
            // Listview leegmaken
            lv_menuitem.Items.Clear();
            try
            {
                // controller aanmaken en menu items ophalen
                MenuItemController menuItemController = new MenuItemController();
                List<MenuItemModel> menuItems = menuItemController.ReadAll();

                // Alle menuitems in de listview zetten
                foreach (MenuItemModel menutItem in menuItems)
                {
                    // Listview item maken en data toevoegen
                    //ListViewItem item = new ListViewItem(menutItem.Subcategorie.Naam);
                    //item.SubItems.Add(menutItem.Naam);
                    //item.SubItems.Add(menutItem.Omschrijving);

                    ListViewItem item = new ListViewItem([menutItem.Subcategorie.Naam,
                        menutItem.Naam,
                        menutItem.Omschrijving]);
                    
                    // Tag aan item toevoegen
                    item.Tag = menutItem;
                    // Item toevoegen aan de listview
                    lv_menuitem.Items.Add(item);
                }
                lv_menuitem.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            catch
            {
                // error message 
                MessageBox.Show("Er is een fout opgetreden bij het ophalen van de menu-items");
            }
        }
        private void btn_Terug_Click(object sender, EventArgs e)
        {
            // Form sluiten
            this.Close();
        }

        private void btn_Toevoegen_Click(object sender, EventArgs e)
        {
            // Toevoegen form openen
            frmMenuItemToevoegen frmMenuItemToevoegen = new frmMenuItemToevoegen();
            frmMenuItemToevoegen.ShowDialog();
            // Listview verversen
            FillListView();
        }

        private void btn_Bewerken_Click(object sender, EventArgs e)
        {
            if (lv_menuitem.SelectedItems.Count == 1)
            {
                try
                {
                    // Geselecteerde menu item ophalen
                    MenuItemModel menuItem = (MenuItemModel)lv_menuitem.SelectedItems[0].Tag;

                    // Bewerken form openen
                    frmMenuItemBewerken frmMenuItemBewerken = new frmMenuItemBewerken(menuItem);
                    frmMenuItemBewerken.ShowDialog();

                    // Listview opnieuw laden
                    FillListView();
                }
                catch
                {
                    // Error message
                    MessageBox.Show("Er is een fout opgetreden bij het bewerken van het menuitem");
                }
            }
            else
            {
                // error message
                MessageBox.Show("Er is geen menu-item geselecteerd");
            }
        }

        private void btn_Verwijderen_Click(object sender, EventArgs e)
        {
            if (lv_menuitem.SelectedItems.Count == 1)
            {
                if (MessageBox.Show("Weet u zeker dat u dit menu-item wilt verwijderen", "Menu-item verwijderen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        // menuitem ophalen
                        MenuItemModel menuItem = (MenuItemModel)lv_menuitem.SelectedItems[0].Tag;

                        // Controller aanroepen
                        MenuItemController menuItemController = new MenuItemController();
                        int rowsAffected = menuItemController.Delete(menuItem);
                        if (rowsAffected == 1)
                        {
                            // succes message
                            MessageBox.Show("Menu-item is verwijderd");

                            // Listview verversen
                            FillListView();
                        }
                        else
                        {
                            // error message
                            MessageBox.Show("Er is een fout opgetreden bij het verwijderen van het menu-item");
                        }

                    }
                    catch
                    {
                        // error message
                        MessageBox.Show("Er is een fout opgetreden bij het verwijderen van het menu-item");
                    }

                }
            }
            else
            {
                // error message
                MessageBox.Show("Er is geen menu-item geselecteerd");
            }
        }
    }
}

