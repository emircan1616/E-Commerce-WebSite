using System.ComponentModel.DataAnnotations;

namespace EvKur.Models.User
{
    public class Customer:BaseOptions
    {
        [Required]
        [StringLength(25)]
        public string MusteriAdi { get; set; }

        [Required]
        [StringLength(25)]
        public string MusteriSoyad { get; set; }

        [Required]
        [StringLength(50)]
        public string KullaniciAdi { get; set; }

        [Required]
        [StringLength(50)]
        public string Sifre { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

    }
}
