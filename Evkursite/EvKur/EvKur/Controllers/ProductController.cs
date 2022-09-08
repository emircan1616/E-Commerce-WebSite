using EvKur.Models.Entity;
using EvKur.Models.Factory;
using EvKur.Models.Session;
using EvKur.Models.Shop;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EvKur.Controllers
{
    public class ProductController : Controller
    {
        private DataContext _dataContext;
        private IWebHostEnvironment _hostEnvironment;

        public ProductController(DataContext dataContext, IWebHostEnvironment hostEnviroment)
        {
            _dataContext = dataContext;
            this._hostEnvironment = hostEnviroment;
        }
        Tedarikci tedarikci = new Tedarikci();
        Product product1 = new Product();
        public IActionResult Index()
        {           
                List<Product> productList = new List<Product>();
                return View(_dataContext.products);            
        }
        public IActionResult SiparisleriListele()
        {
            List<BayiSiparis> productList = new List<BayiSiparis>();
            return View(_dataContext.bayiSiparis);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            List<SelectListItem> degerler = (from i in _dataContext.categories.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.KategoriIsmi
                                             }).ToList();
            ViewBag.dgr = degerler;

            //ürünlere hangi tedarikçiye ait olduğunu göstermek için tedarikçi Id verdiğimiz yer
            AddProduct p = new AddProduct();
            p.Tedarikci = (Tedarikci)HttpContext.Session.GetObjectFromJson<Tedarikci>("tedarikci");

            ViewBag.Category = new SelectList(_dataContext.categories, "Id", "KategoriIsmi");
            return View(p);
        }

        [HttpPost]
        public IActionResult AddProduct(AddProduct addProduct)
        {
            Product product = new Product();
            var dd = HttpContext.Session.GetObjectFromJson<Tedarikci>("tedarikci");
            product.TedarikciId = dd.Id;
            
                if (ModelState.IsValid)
                {
                    if (addProduct.Image != null)
                    {
                        //dosya yolunu tuttuğumuz yer
                        var extension = Path.GetExtension(addProduct.Image.FileName);
                        //her resme özel bir isim atadığımız yer
                        var newimagename = Guid.NewGuid() + extension;
                        //resmin doaya yolunu açtığımız yer
                        var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Image/", newimagename);
                        var stream = new FileStream(location, FileMode.Create);
                        addProduct.Image.CopyTo(stream);
                        product.Image = newimagename;
                    }
                    product.GuncellemeTarihi = DateTime.Now;
                    product.OlusturmaTarihi = DateTime.Now;
                    product.aktifMi = true;
                    product.silindiMi = false;
                    product.UrunAdi = addProduct.UrunAdi;
                    product.UrunAdet = addProduct.UrunAdet;
                    product.OlusturanKullanici = addProduct.OlusturanKullanici;
                    product.OlusturmaTarihi = addProduct.OlusturmaTarihi;
                    product.silindiMi = addProduct.silindiMi;
                    product.aktifMi = addProduct.aktifMi;
                    //product.Tedarikci = addProduct.Tedarikci;
                    //product.TedarikciId = addProduct.TedarikciId;
                    product.Category = addProduct.Category;
                    product.GuncelleyenKisi = addProduct.GuncelleyenKisi;
                    product.GuncellemeTarihi = addProduct.GuncellemeTarihi;
                    product.UrunFiyat = addProduct.UrunFiyat;
                    product.CategoryId = addProduct.CategoryId;
                    _dataContext.Add(product);
                    _dataContext.SaveChanges();
                    return RedirectToAction("Index", "Product");
                }
            return View();
            
            
        }
                
        public ActionResult DeleteProduct(int Id)
        {
            Product product = _dataContext.products.Find(Id);
            _dataContext.products.Remove(product);            
            _dataContext.SaveChanges();
            return RedirectToAction("Index", "Product");
        }

        [HttpGet]
        public IActionResult EditProduct(int id)
        {
            Product product = _dataContext.products.Find(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product productt)
        {
            
            if (ModelState.IsValid)
            {
                Product product = _dataContext.products.FirstOrDefault(i => i.Id == productt.Id);
                product.UrunAdi=productt.UrunAdi;
                product.UrunFiyat = productt.UrunFiyat;
                product.UrunAdet = productt.UrunAdet;
                _dataContext.products.Update(product);
                _dataContext.SaveChanges();
                return RedirectToAction("Index", "Product");
            }
            else
            {
                return RedirectToAction("Index", "Product");
            }
        }
        public IActionResult Back()
        {
            return RedirectToAction("Index", "Product");


        }
    }
}
