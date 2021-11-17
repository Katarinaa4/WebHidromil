using Hidromil.Data;
using Hidromil.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Hidromil.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ApplicationDBContext _db;

        private readonly UserManager<Admin> _userManager;

        public HomeController(ApplicationDBContext db, UserManager<Admin> userManager)
        {
            _db = db;
            _userManager = userManager;
        }

        [BindProperty]
        public IList<Slika> Slike { get; set; }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);

            if (user != null)
            {
                var role = await _userManager.GetRolesAsync(user);
            }
            return View();
        }

        public IActionResult ONama()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Galerija()
        {
            Slike = _db.Slike.ToList();
            ViewBag.Slike = Slike;

            return View();
        }

        public IActionResult Usluge()
        {
            return View();
        }
        public IActionResult Kontakt()
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
