using Hidromil.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hidromil.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDBContext _db;
        public AdminController(ApplicationDBContext db)
        {
            _db = db;
        }
        [HttpGet]
        [Authorize]
        public IActionResult AdminUsluge()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
