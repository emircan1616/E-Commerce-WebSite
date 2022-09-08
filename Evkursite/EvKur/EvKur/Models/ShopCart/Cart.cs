using EvKur.Models.Shop;

namespace EvKur.Models.ShopCart
{
    public class Cart
    {
        private List<CartLine> _cartLines= new List<CartLine>();
        public List<CartLine> CartLines
        {
            get
            {
                return _cartLines;
            }
        }

            public void AddItem(BayiProduct bayiProduct, int quantity)
        {
            var line = _cartLines.FirstOrDefault(i => i.bayiProduct.Id == bayiProduct.Id);
            if (line==null)
            {
                _cartLines.Add(new CartLine() { bayiProduct = bayiProduct, Quantity = 1 });
            }
            else
            {
                line.Quantity += quantity; 
            }
        }
        public void DeleteItem(BayiProduct bayiProduct)
        {
            _cartLines.RemoveAll(i => i.bayiProduct.Id == bayiProduct.Id);
        }

        public decimal? Total()
        {
            return _cartLines.Sum(i => i.bayiProduct.BayiUrunFiyat * i.Quantity);
        }
        public void Clear()
        {
            _cartLines.Clear();
        }


    }
    public class CartLine
    {
        public BayiProduct bayiProduct { get; set; }
        public int Quantity { get; set; }
    }
}
