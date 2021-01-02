using System.ComponentModel.DataAnnotations;
namespace ViewModels.AdminViewModel.Admin
{
    public class Vm_Records
    {
            [Key]
        public int Id { get; set; }
        public string Companyname { get; set; }
        public string start { get; set; }
        public string  End { get; set; }
        public string Typeactivity { get; set; }
    }
}