using Hidromil.Data;
using Hidromil.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Hidromil.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDBContext _db;
        [BindProperty]
        public List<Usluga> Usluge { get; set; }
        [BindProperty]
        public int br { get; set; }
        public Usluga usluga { get; set; }
        public AdminController(ApplicationDBContext db)
        {
            _db = db;
        }

        [HttpGet]
        [Authorize]
        public IActionResult AdminUsluge()
        {
            Usluge = _db.Usluge.ToList();
            ViewBag.Usluge = Usluge;
            
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult AdminDodajUslugu()
        {
            //if(usluga != null)
            //{
            //    _db.Usluge.Add(usluga);
            //    _db.SaveChanges();
            //}
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult DodajUslugu(Usluga usluga)
        {
            if (usluga != null)
            {
                if(usluga.SlikaFajl != null)
                { 
                    var a = usluga.SlikaFajl.OpenReadStream();
                    using (BinaryReader br = new BinaryReader(usluga.SlikaFajl.OpenReadStream()))
                    {
                        byte[] content = br.ReadBytes((int)usluga.SlikaFajl.OpenReadStream().Length);
                        string slikaa = Convert.ToBase64String(content);
                        usluga.Putanja = slikaa;
                    }
                }
                _db.Usluge.Add(usluga);
                _db.SaveChanges();
            }
            return RedirectToAction("AdminUsluge", "Admin");
        }

        [HttpPost]
        [Authorize]
        public IActionResult ObrisiUslugu(int id)
        {
            Usluga usluga = _db.Usluge.Where(x => x.Id == id).FirstOrDefault();
            if(usluga != null)
            {
                _db.Usluge.Remove(usluga);
                _db.SaveChanges();
            }

            return RedirectToAction("AdminUsluge", "Admin");
        }
        

        public IActionResult Index()
        {
            return View();
        }
    }
}
