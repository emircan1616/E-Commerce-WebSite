
using EvKur.Models.Factory;

namespace EvKur.Models.Shop
{
    public class BayiProduct:BaseOptions
    {
        public string? BayiUrunIsim { get; set; }
        public decimal? BayiUrunFiyat { get; set; }
        public Product? product { get; set; }
        public int? productId { get; set; }
        public int? BayiUrunAdet { get; set; }
        public Bayii? Bayi{ get; set; }
        public int? BayiId { get; set; }
        public string? Image { get; set; }
        public Sepet? sepet { get; set; }

    }
}
