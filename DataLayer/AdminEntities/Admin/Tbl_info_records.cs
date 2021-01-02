using System.ComponentModel.DataAnnotations;
namespace DataLayer.AdminEntities.Admin
{
    public class Tbl_info_records
    {
        [Key]
        public string Companyname { get; set; }
        public string start { get; set; }
        public string  End { get; set; }
        public string Typeactivity { get; set; }
        
        
    }
}