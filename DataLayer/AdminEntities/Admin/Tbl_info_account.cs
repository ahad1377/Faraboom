using System.ComponentModel.DataAnnotations;
namespace DataLayer.AdminEntities.Admin
{
    public class Tbl_info_account
    {
        [Key]
        public int Id { get; set; }
        public string Bankname { get; set; }
        public string Bankcode { get; set; }
         public string Branchname { get; set; }
        public string Accounttype { get; set; }
        public string cardnumber { get; set; }
         public string Shabanumber { get; set; }
         public string accountnumber { get; set; }
        public string AccountName { get; set; }
         public string Postalcode { get; set; }
         public string Address{ get; set; }
        
        
    }
}