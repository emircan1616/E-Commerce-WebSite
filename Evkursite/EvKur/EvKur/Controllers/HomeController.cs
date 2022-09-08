using EvKur.Models;
using EvKur.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EvKur.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        
        private DataContext _dataContext;

        public HomeController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public ActionResult LogineGiris()
        {
            return RedirectToAction ("AdminLogin", "Account");
        }
        public ActionResult UserGiris()
        {
            return RedirectToAction("UserLogin", "Account");
        }
        public ActionResult CompanyGiris()
        {
            return RedirectToAction("CompanyLogin", "Account");
        }

        public ActionResult UserKayitGit()
        {
            return RedirectToAction("UserRegister", "Account");
        }

         public ActionResult BayiKayitGit()
        {
            return RedirectToAction("BayiRegister", "Account");
        }
        public ActionResult TedarikciGiris()
        {
            return RedirectToAction("TedarikciLogin", "Account");
        }
        public ActionResult BayiiGiris()
        {
            return RedirectToAction("BayiiLogin", "Account");
        }





        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}