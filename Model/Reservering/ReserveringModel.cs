using Proeflokaal_Project.Model.Klant;
using Proeflokaal_Project.Model.Medewerker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proeflokaal_Project.Model.Reservering
{
    public class ReserveringModel
    {
        public int ReserveringId { get; set; }
        public int Tafel { get; set; }
        public int AantalPersonen { get; set; }
        public DateTime Datum { get; set; }
        public KlantModel Klant { get; set; }
        public MedewerkerModel Medewerker { get; set; }
    }
}
