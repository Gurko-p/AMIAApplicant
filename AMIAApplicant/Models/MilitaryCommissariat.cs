using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMIAApplicant.Models
{
    public class MilitaryCommissariat
    {
        public int Id { get; set; }
        public string MilitaryCommissariatFullName { get; set; }
        public string MilitaryCommissariatShortName { get; set; }
        public string MilitaryCommissariatRegion { get; set; } // Область
        public string MilitaryCommissariatArea { get; set; } // Район
        public string MilitaryCommissariatPostIndex { get; set; } // Почтовый индекс
        public string MilitaryCommissariatStreet { get; set; } // Улица
        public string MilitaryCommissariatHome { get; set; } // Номер дома
    }
}
