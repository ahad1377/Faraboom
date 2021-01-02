using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace ViewModels.AdminViewModel.Admin
{
    public class Vm_Documents
    {
                [Key]
         public int Id { get; set; }
        
        public string photos { get; set; }
        public IFormFile Fphotos { get; set; }
        public string Nationalcard { get; set; }
        public IFormFile FNationalcard { get; set; }
        public string Nationalcardback { get; set; }
        public IFormFile FNationalcardback { get; set; }
        public string Certificate { get; set; }
        public IFormFile FCertificate { get; set; }
        public string Shaba { get; set; }
        public IFormFile FShaba  { get; set; }
        public string Degreeeducation { get; set; }
        public IFormFile FDegreeeducation { get; set; }
        public string Postalcode { get; set; }
        public IFormFile FPostalcode { get; set; }
        public string Document{ get; set; }
        public IFormFile FDocument { get; set; }
        public string Badbackground{ get; set; }
        public IFormFile FBadbackground { get; set; }
        public string Receipt  { get; set; }
        public IFormFile FReceipt { get; set; }
        
    }
}