using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Internet_shop.Models;
using Microsoft.EntityFrameworkCore;

namespace Internet_shop.Controllers
{
    public class HomeController : Controller
    {
        private ShirtContext db;      
               
        public HomeController(ShirtContext context) { db = context; }

        public async Task<IActionResult> Show()
        {
            return View(await db.Shirts.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Shirt shirt)
        {
            db.Shirts.Add(shirt);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NewInd()
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
