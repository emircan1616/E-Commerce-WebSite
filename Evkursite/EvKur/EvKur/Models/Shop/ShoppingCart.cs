namespace EvKur.Models.Shop
{
    public class ShoppingCart : BaseOptions
    {
        public List<Sepet> Items { get; private set; }

        // Readonly properties can only be set in initialization or in a constructor
        public static readonly ShoppingCart Instance;

    }
}
