using EvKur.Models.Factory;

namespace EvKur.Models.Shop
{
    public class ProductOrder:BaseOptions
    {
        public string SiparisUrunAdi { get; set; }
        public int SiparisUrunAdet { get; set; }
        public Bayii? Bayi { get; set; }
        public int? BayiId { get; set; }
        public int? tedarikciId { get; set; }
        public Tedarikci? tedarikci { get; set; }
        public bool UrunDurumu { get; set; }

    }
}
