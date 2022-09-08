using System.ComponentModel.DataAnnotations;

namespace EvKur.Models.Factory
{
    public class Bayii:BaseOptions
    {
        [Required]
        public string BayiAdı { get; set; }
        
        public int? BayiKazanc { get; set; }
        
        public string BayiSifre { get; set; }
        [Required]
        public string BayiAciklama { get; set; }
        [Required]
        public string BayiMail { get; set; }
        [Required]
        public int BayiTelefon { get; set; }



        
        
    }
}
