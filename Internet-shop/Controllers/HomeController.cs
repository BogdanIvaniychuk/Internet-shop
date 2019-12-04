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
        //private JeansContext db_jea;

        public HomeController(ShirtContext context /*JeansContext con_jea*/) { db = context; /*db_jea = con_jea;*/ }

        public async Task<IActionResult> Show()
        {
            return View(await db.Shirts.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Tmpshka tmpshka)
        {
            //db.Shirts.Add(shirt);
            //await db.SaveChangesAsync();

            switch (Convert.ToString(tmpshka.num))
            {
                case "Shirt":
                    {
                        Shirt shirt = tmpshka.ConvertToShirt();
                        db.Shirts.Add(shirt); break;
                    }
                //case "Jeans":
                //    {
                //        Jeans jeans = tmpshka.ConvertToJeans();
                //        db_jea.jeans.Add(jeans); break;
                //    }

                    //----------------------------------------------
                    //case 1:
                    //    db.Shirts.Add(thing.ConvertToShirt()); break;

                    // -----------------------------------------------------------------
            }
            

            await db.SaveChangesAsync();
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
