using Proeflokaal_Project.Model.Subcategorie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proeflokaal_Project.Model.MenuItem
{
    public class MenuItemModel
    {
        public int MenuItemId { get; set; }
        public SubcategorieModel Subcategorie { get; set; }
        public string Naam { get; set; }
        public string Omschrijving { get; set; }
    }
}
