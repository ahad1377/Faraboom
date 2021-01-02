using System.ComponentModel.DataAnnotations;
namespace DataLayer.AdminEntities.Admin {

    public class Tbl_Contact {

        [Key]
        public string Id { get; set; }
        public string Phone { get; set; }
        public string PhonelocationN { get; set; }
        public string PhoneNikatak { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Postalcode { get; set; }
        public string homeaddress { get; set; }
         public string Locationaddress { get; set; }
        

    }
}