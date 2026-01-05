using Proeflokaal_Project.View.Categorie;
using Proeflokaal_Project.View.Klant;
using Proeflokaal_Project.View.Login;
using Proeflokaal_Project.View.Medewerker;
using Proeflokaal_Project.View.MenuItem;
using Proeflokaal_Project.View.Reservering;
using Proeflokaal_Project.View.Subcategorie;

namespace Proeflokaal_Project
{
    public partial class frmHomepagina : Form
    {
        public frmHomepagina()
        {
            InitializeComponent();
        }

        private void btn_ReserveringenOverzicht_Click(object sender, EventArgs e)
        {
            // Form openen 
            frmReserveringOverzicht frmReserveringOverzicht = new frmReserveringOverzicht();
            frmReserveringOverzicht.ShowDialog();
        }

        private void btn_CategorieOverzicht_Click(object sender, EventArgs e)
        {
            // Form openen
            frmCategorieOverzicht frmCategorieOverzicht = new frmCategorieOverzicht();
            frmCategorieOverzicht.ShowDialog();
        }

        private void btn_SubcategorieOverzicht_Click(object sender, EventArgs e)
        {
            // Form openen
            frmSubcategorie frmSubcategorie = new frmSubcategorie();
            frmSubcategorie.ShowDialog();
        }

        private void btn_MenuItemOverzicht_Click(object sender, EventArgs e)
        {
            // Form openen
            frmMenuItemOverzicht frmMenuItemOverzicht = new frmMenuItemOverzicht();
            frmMenuItemOverzicht.ShowDialog();
        }

        private void btn_KlantenOverzicht_Click(object sender, EventArgs e)
        {
            // Form openen
            frmKlantOverzicht frmKlantOverzicht = new frmKlantOverzicht();
            frmKlantOverzicht.ShowDialog();
        }

        private void btn_MedewerkerOverzicht_Click(object sender, EventArgs e)
        {
            // Form openen
            frmMedewerkerOverzicht frmMedewerkerOverzicht = new frmMedewerkerOverzicht();
            frmMedewerkerOverzicht.ShowDialog();
        }

        private void btn_Inloggen_Click(object sender, EventArgs e)
        {
            // Form openen
            frmInloggen frmInloggen = new frmInloggen();
            frmInloggen.ShowDialog();
        }
    }
}
