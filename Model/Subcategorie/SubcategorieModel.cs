using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proeflokaal_Project.Model;
using Proeflokaal_Project.Model.Categorie;

namespace Proeflokaal_Project.Model.Subcategorie
{
    public class SubcategorieModel
    {
        public int SubcategorieId { get; set; }
        public CategorieModel Categorie { get; set; }
        public string Naam { get; set; }
    }
}
