using EvKur.Models.Entity;
using EvKur.Models.Factory;
using EvKur.Models.Shop;
using Microsoft.AspNetCore.Mvc;

namespace EvKur.Controllers
{
    public class CompanyController : Controller
    {
        private readonly DataContext _dataContext;
        
        public CompanyController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult StokDurum()
        {
            List<BayiProduct> bayiProducts = new List<BayiProduct>();
            return View(_dataContext.bayiProducts);
           
        }
        public IActionResult VisualizeProductResultBayi()
        {
            return Json(BayiList());
        }
        public List<Class> BayiList()
        {
            List<Class> cs = new List<Class>();
            using (_dataContext)
            {
                cs = _dataContext.bayiProducts.Select(x => new Class
                {
                    proname = x.BayiUrunIsim,
                    stock = x.BayiUrunAdet
                }).ToList();

            }
            return cs;
        }
        public IActionResult Index2()
        {
            List<Product> productList = new List<Product>();
            return View(_dataContext.products);
            
        }
        public IActionResult VisualizeProductResult()
        {
            return Json(ProList());
        }
        public List<Class> ProList()
        {
            List<Class> cs = new List<Class>();            
            using (_dataContext)
            {
                cs = _dataContext.products.Select(x => new Class
                {
                    proname = x.UrunAdi,
                    stock = x.UrunAdet
                }).ToList();

            }
            return cs;
        }

        public ActionResult TedarikcileriGoruntule()
        {
            List<Tedarikci> tedarikcis = new List<Tedarikci>();
            return View(_dataContext.tedarikcis);
        }

        public ActionResult TedarikciSil(int Id)
        {
            Tedarikci tedarikci= _dataContext.tedarikcis.Find(Id);
            _dataContext.tedarikcis.Remove(tedarikci);
            _dataContext.SaveChanges();
            return View();
        }

        public ActionResult BayileriGoruntule()
        {
            List<Bayii> bayiis = new List<Bayii>();
            return View(_dataContext.bayiis);
        }
        public ActionResult BayiSil(int Id)
        {
            Bayii bayii = _dataContext.bayiis.Find(Id);
            _dataContext.bayiis.Remove(bayii);
            _dataContext.SaveChanges();
            return View();
        }
    }
}
