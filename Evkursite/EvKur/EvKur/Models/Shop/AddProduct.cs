using EvKur.Models.Factory;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace EvKur.Models.Shop
{
    public class AddProduct: BaseOptions
    {
        public string UrunAdi { get; set; }
        public decimal UrunFiyat { get; set; }
        public int UrunAdet { get; set; }

        public int TedarikciId { get; set; }
        public Tedarikci? Tedarikci { get; set; }

        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        [NotMapped]
        public IFormFile Image { get; set; }
    }
}
