using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EfCodeFirstApp.Models;
using EfCodeFirstApp.Data;
using Microsoft.EntityFrameworkCore;

namespace EfCodeFirstApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly Context db;

        public HomeController(Context db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            //IQueryable<Car> model = db.Cars;
            //var x = model.ToList();
            IEnumerable<Car> model = db.Cars.Include(a=>a.CarModel).ToList();
            return View(model);
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
