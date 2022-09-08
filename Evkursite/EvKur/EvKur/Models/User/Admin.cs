using System.ComponentModel.DataAnnotations;

namespace EvKur.Models.User
{
    public class Admin:BaseOptions
    {
        [Required]
        [StringLength(25)]
        public string AdminAdi { get; set; }

        [Required]
        [StringLength(25)]
        public string AdminSoyad { get; set; }

        [Required]
        [StringLength(50)]
        public string KullaniciAdi { get; set; }

        [Required]
        [StringLength(50)]
        public string Sifre { get; set; }
    }
}
