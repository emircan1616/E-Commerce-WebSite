using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EvKur.Models.SignIn
{
    public class Login:BaseOptions
    {
        [Required]
        [DisplayName("Kullanici Adi")]
        public string KullaniciAdi { get; set; }

        [Required]
        [DisplayName("Kullanici Sifre")]
        public string KullaniciSifre { get; set; }
        public bool Benihatirla { get; set; }
    }
}
