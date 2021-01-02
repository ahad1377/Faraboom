using System.ComponentModel.DataAnnotations;
namespace ViewModels.AdminViewModel.Admin
{
    public class  Vm_Persenal
    {
            [Key]
         public int Id { get; set; }
         public string Nameper { get; set; }
         public string Familyper{ get; set; }
         public string Fathernameper{ get; set; }
         public string NationalCode { get; set; }
         public string Nameen { get; set; }
         public string Familyen{ get; set; }
         public string Fathernameen{ get; set; }
         public string NationalCode { get; set; }
         public string Place{ get; set; }
         public string Serial{ get; set; }
         public string Religion{ get; set; }
         public string Email{ get; set; }
         public string  Datebirth{ get; set; }
         public string  Gender{ get; set; }
         public string  maritalstatus { get; set; } 
    }
}