namespace EvKur.Models.Shop
{
    public class Category:BaseOptions
    {
        public string KategoriIsmi { get; set; }
       public virtual List<Product>? Products { get; set; }
    }
}
