using System.ComponentModel.DataAnnotations;
namespace DataLayer.AdminEntities.Admin
{
    public class Tbl_info_documents
    {
        [Key]
        public string photos { get; set; }
        public string Nationalcard { get; set; }
        public string Nationalcardback { get; set; }
        public string Certificate { get; set; }
        public string Shaba { get; set; }
        public string Degreeeducation { get; set; }
        public string Postalcode { get; set; }
        public string Document{ get; set; }
        public string Badbackground{ get; set; }
        public string Receipt  { get; set; }
        
        
    }
}