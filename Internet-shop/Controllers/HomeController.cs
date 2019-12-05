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
        private JeansContext db_jea;
        private HatContext db_hat;

        public HomeController(ShirtContext context, JeansContext con_jea, HatContext con_hat) { db = context; db_jea = con_jea; db_hat = con_hat; }

        public async Task<IActionResult> Show()
        {
            return View(await db.Shirts.ToListAsync());
        }

        public async Task<IActionResult> ShowJeans()
        {
            return View(await db_jea.jeans.ToListAsync());
        }

        public async Task<IActionResult> ShowHats()
        {
            return View(await db_hat.Hats.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Tmpshka tmpshka)
        {
            switch (Convert.ToString(tmpshka.num))
            {
                case "Shirt":
                    {
                        Shirt shirt = tmpshka.ConvertToShirt();
                        db.Shirts.Add(shirt);
                        await db.SaveChangesAsync(); 
                        break;
                    }
                case "Jeans":
                    {
                        Jeans jeans = tmpshka.ConvertToJeans();
                        db_jea.jeans.Add(jeans);
                        await db_jea.SaveChangesAsync();
                        break;
                    }
                case "Hats":
                    {
                        Hat hat = tmpshka.ConvertToHat();
                        db_hat.Hats.Add(hat);
                        await db_hat.SaveChangesAsync();
                        break;
                    }
            }                       
            return RedirectPermanent("~/Home/Index");
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
