using EvKur.Models.Entity;
using EvKur.Models.Factory;
using EvKur.Models.Session;
using EvKur.Models.Shop;
using EvKur.Models.ShopCart;
using EvKur.Models.User;
using Microsoft.AspNetCore.Mvc;

namespace EvKur.Controllers
{
    public class ShopController : Controller
    {


        private DataContext _dataContext;

        public ShopController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        [HttpGet]
        public ActionResult MarketeYukle(int Id)//sepet ekle fonksiyonunun aynısı yazılacak fakat artırma ve azaltma olmayacak.
        {
            BayiProduct bayi = _dataContext.bayiProducts.FirstOrDefault(i => i.Id == Id);
            return View(_dataContext.bayiProducts);
        }
        public ActionResult SepetiGoruntule()
        {
            List<Sepet> sepets = new List<Sepet>();
            return View(_dataContext.sepet.Distinct());
        }

        [HttpGet]
        public ActionResult SepeteEkle(int Id)//bayi producttan ürün çekip sepetproducta ekleyeceğiz. Session Atamalarını Yap
        {
            var dd = HttpContext.Session.GetObjectFromJson<Customer>("user");
            Sepet sepet = _dataContext.sepet.FirstOrDefault(t => t.customerId == dd.Id);
            if (sepet == null)
            {
                sepet = new Sepet();
            }
            else
            {

            }
            sepet.customerId = dd.Id;
            BayiProduct bayiProduct = _dataContext.bayiProducts.FirstOrDefault(i => i.productId == Id);
            Product product = _dataContext.products.FirstOrDefault(x => x.Id == Id);
            var kontrol = _dataContext.sepet.Any(x => x.productId == product.Id);
            if (kontrol == true)
            {
                sepet.SepetUrunAdet++;
                _dataContext.sepet.Update(sepet);
                bayiProduct.BayiUrunAdet--;
                _dataContext.bayiProducts.Update(bayiProduct);
                _dataContext.SaveChanges();
                return RedirectToAction("MarketeYukle", "Shop");
            }
            else
            {
                sepet.bayiProduct = bayiProduct;
                sepet.productId = product.Id;
                sepet.GuncellemeTarihi = DateTime.Now;
                sepet.OlusturmaTarihi = DateTime.Now;
                sepet.aktifMi = true;
                sepet.silindiMi = false;
                sepet.SepetUrunFiyat = bayiProduct.BayiUrunFiyat;
                sepet.SepetUrunAdi = bayiProduct.BayiUrunIsim;
                sepet.SepetUrunAdet = bayiProduct.BayiUrunAdet;
                sepet.Image = bayiProduct.Image;
                bayiProduct.BayiUrunAdet--;
                _dataContext.bayiProducts.Update(bayiProduct);
                sepet.SepetUrunAdet = 0;
                sepet.SepetUrunAdet += 1;
                _dataContext.sepet.Update(sepet);
                _dataContext.SaveChanges();
                return RedirectToAction("MarketeYukle", "Shop");
            }
            //if (bayiProduct.productId==sepet.productId)//delete olacak bayiproduct
            //{
            //    bayiProduct.BayiUrunAdet --;
            //    _dataContext.bayiProducts.Update(bayiProduct);
            //    sepet.SepetUrunAdet = 0;
            //    sepet.SepetUrunAdet += 1;
            //    _dataContext.sepet.Update(sepet);
            //    _dataContext.SaveChanges();
            //    return RedirectToAction("MarketeYukle", "Shop");
            //}
            //else
            //{
            //    bayiProduct.BayiUrunAdet--;
            //    _dataContext.bayiProducts.Update(bayiProduct);
            //    sepet.SepetUrunAdet = 0;
            //    sepet.SepetUrunAdet += 1;
            //    _dataContext.sepet.Update(sepet);
            //    _dataContext.SaveChanges();
            //    return RedirectToAction("MarketeYukle", "Shop");
            //}
        }
        public ActionResult SepetiSil(int Id)
        {
            BayiProduct bayiProduct = new BayiProduct();
            Sepet sepet = _dataContext.sepet.FirstOrDefault(i => i.Id == Id);

            bayiProduct.BayiUrunFiyat = sepet.SepetUrunFiyat;
            bayiProduct.BayiUrunIsim = sepet.SepetUrunAdi;
            bayiProduct.BayiUrunAdet = sepet.SepetUrunAdet;
            bayiProduct.Image = sepet.Image;
            bayiProduct.sepet = sepet;

            sepet.SepetUrunAdet--;
            _dataContext.sepet.Update(sepet);
            bayiProduct.BayiUrunAdet = 0;
            bayiProduct.BayiUrunAdet += 1;
            _dataContext.bayiProducts.Update(bayiProduct);
            _dataContext.SaveChanges();
            return RedirectToAction("SepetiGoruntule", "Shop");
        }
        public ActionResult SatinAl(int Id)
        {
            Sepet sepet = _dataContext.sepet.FirstOrDefault(i => i.Id == Id);
            _dataContext.sepet.Remove(sepet);
            _dataContext.SaveChanges();
            return RedirectToAction("SepetiGoruntule", "Shop");
        }
        public IActionResult Index()
        {
            return View();
        }




    }
}
