using EvKur.Models.Entity;
using EvKur.Models.Factory;
using EvKur.Models.Session;
using EvKur.Models.SignIn;
using EvKur.Models.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Claims;

namespace EvKur.Controllers
{
    public class AccountController : Controller
    {
        private DataContext _dataContext;

        public AccountController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public ActionResult LogOut()
        {
            return View("Login");
        }
        public ActionResult UserRegister()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UserRegister(Customer customer)
        {
            if (ModelState.IsValid)
            {
                customer.GuncelleyenKisi = ("emircan");
                customer.OlusturanKullanici = ("emrecn");
                customer.OlusturmaTarihi = DateTime.Now;
                customer.GuncellemeTarihi = DateTime.Now;
                customer.aktifMi = true;
                customer.silindiMi = false;
                _dataContext.Add(customer);
                _dataContext.SaveChanges();
                return RedirectToAction(/*"Index", "Home"*/);
            }
            else
            {
                return View();
            }

        }
        public ActionResult BayiRegister()
        {
            return View();
        }

        [HttpPost]
        public IActionResult BayiRegister(Bayii bayii)
        {
            if (ModelState.IsValid)
            {
                bayii.BayiKazanc = null;
                bayii.GuncelleyenKisi = "emircan";
                bayii.OlusturanKullanici = "emrecn";
                bayii.OlusturmaTarihi = DateTime.Now;
                bayii.GuncellemeTarihi = DateTime.Now;
                bayii.aktifMi = true;
                bayii.silindiMi = false;

                _dataContext.Add(bayii);
                _dataContext.SaveChanges();
                return RedirectToAction(/*"Index", "Home"*/);
            }
            else
            {
                return View();
            }
        }

        //public ActionResult AdminRegister()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public IActionResult AdminRegister(Admin admin)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        admin.GuncelleyenKisi = ("emircan");
        //        admin.OlusturanKullanici = ("emrecn");
        //        admin.OlusturmaTarihi = DateTime.Now;
        //        admin.GuncellemeTarihi = DateTime.Now;
        //        admin.aktifMi = true;
        //        admin.silindiMi = false;


        //        _dataContext.Add(admin);
        //        _dataContext.SaveChanges();
        //        return RedirectToAction("Index", "Home");

        //    }
        //    else
        //    {
        //        return View();
        //    }

        //}

        public ActionResult UserLogin()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UserLogin(Login login)
        {
            var bilgiler = _dataContext.customers.FirstOrDefault(customer => customer.KullaniciAdi == login.KullaniciAdi && customer.Sifre == login.KullaniciSifre);
            if (bilgiler == null)
            {
                return View();
            }
            var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, login.KullaniciAdi)
                };
            var useridentity = new ClaimsIdentity(claims, "Account");
            ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
            HttpContext.Session.SetObjectAsJson("user", bilgiler);
            return RedirectToAction("MarketeYukle", "Shop");
        }
        public ActionResult AdminLogin()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AdminLogin(Login login)
        {
            var bilgiler = _dataContext.admin.FirstOrDefault(Admin => Admin.KullaniciAdi == login.KullaniciAdi && Admin.Sifre == login.KullaniciSifre);
            if (bilgiler != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, login.KullaniciAdi)
                };
                var useridentity = new ClaimsIdentity(claims, "Account");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                return RedirectToAction("Index", "Home");
            }

            return View();
        }
        public ActionResult CompanyLogin()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CompanyLogin(Login login)
        {
            var bilgiler = _dataContext.companies.FirstOrDefault(Company => Company.SirketIsmi == login.KullaniciAdi && Company.SirketSifre == login.KullaniciSifre);
            if (bilgiler != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, login.KullaniciAdi)
                };
                var useridentity = new ClaimsIdentity(claims, "Account");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                return RedirectToAction("Index", "Company");
            }

            return View();
        }
        public ActionResult TedarikciLogin()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> TedarikciLogin(Login login)
        {
            //string UserType = "Tedarikçi";
            //giriş yapan tedarikcinin id sini tut
            //List<SelectListItem> idler = (from i in _dataContext.tedarikcis.ToList()
            //                              select new SelectListItem
            //                              {
            //                                  Text = i.Id.ToString()
            //                              }).ToList();
            //ViewBag.id = idler;
            var bilgiler = _dataContext.tedarikcis.FirstOrDefault(Tedarikci => Tedarikci.TedarikciIsmi == login.KullaniciAdi && Tedarikci.TedarikciSifre == login.KullaniciSifre);
            if (bilgiler != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, login.KullaniciAdi)
                };
                var useridentity = new ClaimsIdentity(claims, "Account");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                HttpContext.Session.SetObjectAsJson("tedarikci", bilgiler);
                return RedirectToAction("Index", "Category");
            }
            return View();
        }
        public ActionResult BayiiLogin()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> BayiiLogin(Login login)
           { 
            var bilgiler = _dataContext.bayiis.FirstOrDefault(Bayii=> Bayii.BayiAdı== login.KullaniciAdi && Bayii.BayiSifre== login.KullaniciSifre);
            if (bilgiler != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, login.KullaniciAdi)
                };
                var useridentity = new ClaimsIdentity(claims, "Account");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                HttpContext.Session.SetObjectAsJson("bayi", bilgiler);
                return RedirectToAction("Index", "Account");
            }
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
