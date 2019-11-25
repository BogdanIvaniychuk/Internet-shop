using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Internet_shop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Internet_shop.Controllers
{
    public class RegistrationController : Controller
    {
        private HumanContext db_human;

        public RegistrationController(HumanContext human_context) { db_human = human_context; }

        public IActionResult CreateHuman()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateHuman(Human human)
        {
            db_human.Humen.Add(human);
            await db_human.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> ShowHuman()
        {
            return View(await db_human.Humen.ToListAsync());
        }
    }
}