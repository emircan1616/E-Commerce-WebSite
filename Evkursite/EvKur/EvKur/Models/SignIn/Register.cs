using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EvKur.Models.SignIn
{
    public class Register:BaseOptions
    {
        [Required]
        [DisplayName("Ad")]
        public string Ad { get; set; }

        [Required]
        [DisplayName("Soyad")]
        public string Soyad{ get; set; }

        [Required]
        [DisplayName("Kullanici Adi")]
        public string KullaniciAdi { get; set; }

        [Required]
        [DisplayName("Kullanici Sifre")]
        public string KullaniciSifre { get; set; }

        [Required]
        [DisplayName("Mail Adres")]
        [EmailAddress(ErrorMessage ="Geçersiz Mail...")]
        public string MailAdres { get; set; }

        [Required]
        [Compare("KullaniciSifre", ErrorMessage ="parolaniz Uyusmuyor...")]
        [DisplayName("Parola Tekrar")]
        public string KullaniciSifreTekrar { get; set; }

    }
}
