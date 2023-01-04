using CarWebApp.Models;
using CarWebApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly Database _db;
        public HomeController(Database db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            HomeViewModel model = new HomeViewModel
            {
                Brands = _db.Brands.Include(m=>m.Models).ToList(),
                Cars = _db.Cars.Include(ci=>ci.CarImages).ToList(),
            };
            return View(model);
        }
        public IActionResult Detail(int id)
        {
            List<Brand> Brands = _db.Brands.Include(m => m.Models).ToList();
            Car car =_db.Cars.FirstOrDefault(x=>x.Id==id);
            return View(car);
        }
    }
}
