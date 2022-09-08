using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EvKur.Models
{
    public class BaseOptions
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? GuncelleyenKisi { get; set; }
        public string? OlusturanKullanici { get; set; }
        public DateTime OlusturmaTarihi { get; set; }
        public DateTime GuncellemeTarihi { get; set; }        
        public bool silindiMi { get; set; }
        public bool aktifMi{ get; set; }
}
}
