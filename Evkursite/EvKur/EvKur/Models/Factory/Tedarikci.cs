using EvKur.Models.Shop;

namespace EvKur.Models.Factory
{
    public class Tedarikci:BaseOptions
    {
      
        public string TedarikciIsmi { get; set; }
        public string TedarikciSifre { get; set; }

        public  List<Product>? Products { get; set; }

    }
}
