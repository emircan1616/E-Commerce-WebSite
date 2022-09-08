using EvKur.Models.Entity;
using EvKur.Models.Shop;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EvKur.Controllers
{
    public class CategoryController : Controller
    {
        private DataContext _dataContext;

        public CategoryController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult ListeGoster()
        {
            List<Category> CategoryList = new List<Category>();
            return View(_dataContext.categories);
        }
        public ActionResult AddCategory()
        {
            return View();
            
        }
        [HttpPost]
        public ActionResult AddCategory(Category category)
        {
            if (ModelState.IsValid)
            {
                category.GuncellemeTarihi = DateTime.Now;
                category.OlusturmaTarihi = DateTime.Now;
                category.aktifMi = true;
                category.silindiMi = false;
                _dataContext.Add(category);
                _dataContext.SaveChanges();

                return RedirectToAction("ListeGoster", "Category");
            }
            else
            {
                return View();
            }

        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Category category = _dataContext.categories.Find(id);
            return View(category);
            
        }
        [HttpPost]
        public ActionResult EditCategory(Category categoryy)
        {
            if (ModelState.IsValid)
            {
                Category category = _dataContext.categories.FirstOrDefault(i => i.Id == categoryy.Id);
                category.KategoriIsmi = categoryy.KategoriIsmi;                
                _dataContext.categories.Update(category);
                _dataContext.SaveChanges();
                return RedirectToAction("ListeGoster", "Category");
            }
            else
            {
                return RedirectToAction("ListeGoster", "Category");
            }
        }

        public ActionResult DeleteCategory(int Id)
        {
            Category category= _dataContext.categories.Find(Id);
            _dataContext.categories.Remove(category);
            _dataContext.SaveChanges();           
            return RedirectToAction("ListeGoster", "Category");
        }


        
    }
}
