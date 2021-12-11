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
        public Kontakt Kontakt { get; set; }
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
        public IActionResult AdminUsluge1()
        {
            Usluge = _db.Usluge.ToList();
            ViewBag.Usluge = Usluge;

            return RedirectToAction("AdminUsluge", "Admin");
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
            ViewBag.usluga = usluga;

            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult Obrisi(int id)
        {
            Usluga usluga = _db.Usluge.Where(x => x.Id == id).FirstOrDefault();
            if(usluga != null)
            {
                _db.Usluge.Remove(usluga);
                _db.SaveChanges();
            }

            return RedirectToAction("AdminUsluge", "Admin");
        }

        [HttpGet]
        [Authorize]
        public IActionResult AdminKontakt()
        {
            Kontakt = _db.Kontakt.FirstOrDefault();
            ViewBag.Kontakt = Kontakt;
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult AdminKontakt1()
        {
            Kontakt = _db.Kontakt.FirstOrDefault();
            ViewBag.Kontakt = Kontakt;
            return RedirectToAction("AdminKontakt","Admin");
        }

        [HttpPost]
        [Authorize]
        public IActionResult AdminDodajKontakt()
        {
            Kontakt kontakt = new Kontakt();
            kontakt.Email = "servishidromil@gmail.com";
            kontakt.FiksniBr = "8356 806";
            kontakt.MobilniBr = "+381 62 124 99 56";
            kontakt.Napomena = "";
            _db.Kontakt.Add(kontakt);
            _db.SaveChanges();
            return RedirectToAction("AdminKontakt","Admin");
        }

        [HttpPost]
        [Authorize]
        public IActionResult IzmeniInformacije()
        {
            Kontakt = _db.Kontakt.FirstOrDefault();
            ViewBag.Kontakt = Kontakt;
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult UpdateKontakt(Kontakt kontakt)
        {
            Kontakt = _db.Kontakt.FirstOrDefault();
            if (kontakt.Email != null)
                Kontakt.Email = kontakt.Email;
            if (kontakt.FiksniBr != null)
                Kontakt.FiksniBr = kontakt.FiksniBr;
            if (kontakt.MobilniBr != null)
                Kontakt.MobilniBr = kontakt.MobilniBr;
            _db.Kontakt.Update(Kontakt);
            _db.SaveChanges();
            return RedirectToAction("AdminKontakt", "Admin");
        }

        [HttpPost]
        [Authorize]
        public IActionResult DodajNapomenu()
        {
            Kontakt = _db.Kontakt.FirstOrDefault();
            ViewBag.Kontakt = Kontakt;
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult SacuvajPromenu(Kontakt kontakt)
        {
            Kontakt = _db.Kontakt.FirstOrDefault();
            if(kontakt.Napomena != null)
            {
                Kontakt.Napomena = kontakt.Napomena;
                _db.Kontakt.Update(Kontakt);
                _db.SaveChanges();
            }
            return RedirectToAction("AdminKontakt","Admin");
        }

        [HttpPost]
        [Authorize]
        public IActionResult SacuvajNapomenu(Kontakt kontakt)
        {
            Kontakt = _db.Kontakt.FirstOrDefault();
            if (kontakt.Napomena != null)
            {
                Kontakt.Napomena = kontakt.Napomena;
                _db.Kontakt.Update(Kontakt);
                _db.SaveChanges();
            }
            return RedirectToAction("AdminKontakt", "Admin");
        }

        [HttpPost]
        [Authorize]
        public IActionResult UkloniNapomenu()
        {
            Kontakt = _db.Kontakt.FirstOrDefault();
            if (Kontakt.Napomena != null)
            {
                Kontakt.Napomena = null;
                _db.Kontakt.Update(Kontakt);
                _db.SaveChanges();
                
            }
            return RedirectToAction("AdminKontakt", "Admin");
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
