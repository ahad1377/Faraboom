using System.ComponentModel.DataAnnotations;
namespace DataLayer.AdminEntities.Admin {
    public class Tbl_Level {

        [Key]
        public string Id { get; set; }
        
        public string DiplomDate { get; set; }
        public string DiplomLocation { get; set; }

        public string KardaniDate { get; set; }
        public string KardaniLocation { get; set; }

        public string KarshenasiDate { get; set; }
        public string KarshenasiLocation { get; set; }

        public string ArshadDate { get; set; }
        public string ArshadLocation { get; set; }

        public string DoktoraDate { get; set; }
        public string DoktoraLocation { get; set; }

    }
}