using EvKur.Models;
using EvKur.Models.Entity;
using EvKur.Models.Factory;
using EvKur.Models.Session;
using EvKur.Models.Shop;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace EvKur.Controllers
{
    public class BayiController : Controller
    {
        private DataContext _dataContext;
        private readonly IWebHostEnvironment _HostEnvironment;
        public BayiController(DataContext dataContext, IWebHostEnvironment hostEnvironment)
        {
            _dataContext = dataContext;
            this._HostEnvironment = hostEnvironment;
        }
        public ActionResult TedarikcileriListele()
        {
            List<Product> productList = new List<Product>();
            return View(_dataContext.products);
        }
        public ActionResult BayiUrunleriListele()
        {
            List<BayiProduct> bayiProductsList = new List<BayiProduct>();
            return View(_dataContext.bayiProducts);
        }
        public ActionResult SiparisGecmisi()
        {
            List<BayiSiparis> productList = new List<BayiSiparis>();
            return View(_dataContext.bayiSiparis);
        }
        public ActionResult MarketSiparisListesi()
        {
            List<BayiProduct> bayiProducts = new List<BayiProduct>();
            return View(_dataContext.bayiProducts);
        }
        public ActionResult YuklenecekUrunListesi()
        {
            List<BayiProduct> bayiProductsList = new List<BayiProduct>();
            return View(_dataContext.bayiProducts);
        }
        public ActionResult MarketeYukle(int Id)
        {
            List<BayiProduct> bayiProducts = new List<BayiProduct>();
            BayiProduct bayiProduct = _dataContext.bayiProducts.FirstOrDefault(i => i.Id == Id);
            //List<BayiProduct> bayiProducts = new List<BayiProduct>();           
            return RedirectToAction("YuklenecekUrunListesi", bayiProduct);
        }
        [HttpGet]
        public ActionResult BayiyeSiparisVer(int Id)//producttan ürün çekip bayiproduct'a ekliyor
        {
            Tedarikci tedarikci = new Tedarikci();
            BayiProduct bayiProduct = new BayiProduct();
            var dd = HttpContext.Session.GetObjectFromJson<Tedarikci>("bayi");
            bayiProduct.BayiId = dd.Id;
            Product product = _dataContext.products.FirstOrDefault(i => i.Id == Id);
            bayiProduct.GuncellemeTarihi = DateTime.Now;
            bayiProduct.OlusturmaTarihi = DateTime.Now;
            bayiProduct.aktifMi = true;
            bayiProduct.silindiMi = false;
            bayiProduct.product = product;
            bayiProduct.BayiUrunIsim = product.UrunAdi;
            bayiProduct.BayiUrunFiyat = product.UrunFiyat;
            bayiProduct.Image = product.Image;
            //bu kısıma product.cs den gelen img değişkenini atayacağız!!
            //_dataContext.products.Remove(product.UrunAdet);
            product.UrunAdet--;
            _dataContext.products.Update(product);
            bayiProduct.BayiUrunAdet = 0;
            bayiProduct.BayiUrunAdet ++;
            _dataContext.bayiProducts.Update(bayiProduct);
            _dataContext.SaveChanges();
            return RedirectToAction("TedarikcileriListele", "Bayi");
                
                
                       
            
        }
        public ActionResult SiparisOlustur()
        {

            ViewBag.dgr = new SelectList(_dataContext.tedarikcis.ToList(), "Id", "TedarikciIsmi");
            return View();
        }
        [HttpPost]
        public ActionResult SiparisOlustur(BayiSiparis bayiSiparis)
        {
            ViewBag.dgr = new SelectList(_dataContext.tedarikcis.ToList(), "Id", "TedarikciIsmi");

            if (ModelState.IsValid)
            {
                bayiSiparis.GuncellemeTarihi = DateTime.Now;
                bayiSiparis.OlusturmaTarihi = DateTime.Now;
                bayiSiparis.aktifMi = true;
                bayiSiparis.silindiMi = false;
                bayiSiparis.SiparisDurumu = false;
                _dataContext.Add(bayiSiparis);
                _dataContext.SaveChanges();
                return RedirectToAction("TedarikcileriListele", "Bayi");
            }
            else
            {
                return View();
            }
        }


        
        
    } 
}
