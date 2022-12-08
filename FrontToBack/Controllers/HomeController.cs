using FrontToBack.DAL;
using FrontToBack.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FrontToBack.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _dbContext;
        public HomeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var cars = _dbContext.Cars.ToList();
            var brands = _dbContext.Brands.ToList();

            HomeViewModel model = new HomeViewModel
            {
                Cars = cars,
                Brands = brands
            };

            return View(model);
        }
    }
}