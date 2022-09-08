using EvKur.Models.Factory;

namespace EvKur.Models.Shop
{
    public class Product:BaseOptions
    {
        public string? UrunAdi { get; set; }
        public decimal? UrunFiyat { get; set; }
        public int? UrunAdet { get; set; }       

        public int? TedarikciId { get; set; }
        public  Tedarikci? Tedarikci { get; set; }

        public int? CategoryId { get; set; }
        public  Category? Category { get; set; }
        public string? Image { get; set; }
        
        


    }
}
