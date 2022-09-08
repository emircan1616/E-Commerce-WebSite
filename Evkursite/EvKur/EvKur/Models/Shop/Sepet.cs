using EvKur.Models.Factory;
using EvKur.Models.User;

namespace EvKur.Models.Shop
{
    public class Sepet : BaseOptions
    {
        //her kullanıcnın farklı bir sepeyti olacağı için buraya session tanımlanacak normal listele fonksiyonu gibi fonksiyon yazlcakl
        //public List<BayiProduct> bayiProducts { get; set; }
        //public ICollection<BayiProduct>bayiProductss{get;set;}       
       
        public int? SepetUrunAdet{ get; set; }
        public int? productId { get; set; }
        public Product? product { get; set; }
        public decimal? SepetUrunFiyat { get; set; }
        public int? BayiId { get; set; }
        public Bayii? Bayi { get; set; }
        public int? bayiProductId { get; set; }
        public BayiProduct? bayiProduct { get; set; }        
        public string? SepetUrunAdi { get; set; }
        public string? Image { get; set; }
        public int? customerId { get; set; }
        public Customer? customer { get; set; }
        


    }
}
