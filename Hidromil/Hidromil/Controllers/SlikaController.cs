using Hidromil.Data;
using Hidromil.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Hidromil.Controllers
{
    public class SlikaController : Controller
    {
        private readonly ApplicationDBContext _db;

        [BindProperty]
        public Slika slika { get; set; }

        [BindProperty]
        public IList<Slika> slike { get; set; }

        [BindProperty]
        public int br { get; set; }


        [BindProperty]
        public IList<Slika> Slike { get; set; }


        public SlikaController(ApplicationDBContext db)
        {
            _db = db;
        }

        public IActionResult Slika(int? Id)
        {
            slika = _db.Slike.Where(x => x.Id == Id).FirstOrDefault();
            ViewBag.slika = slika;
            slike = _db.Slike.ToList();
            ViewBag.slike = slike;
            br = slike.Count();
            ViewBag.br = br;
            return View();
        }
        
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpGet]
        [Authorize]
        public IActionResult IndexSlikaAdmin()
        {
            return View();
        }

        [Authorize]
        public IActionResult GalerijaAdmin()
        {
            Slike = _db.Slike.ToList();
            ViewBag.Slike = Slike;
            return View();
        }

        [HttpGet]
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Slika slika)
        {
            if (slika.SlikaFajl != null)
            {
                var a = slika.SlikaFajl.OpenReadStream();
                using (BinaryReader br = new BinaryReader(slika.SlikaFajl.OpenReadStream()))
                {
                    byte[] content = br.ReadBytes((int)slika.SlikaFajl.OpenReadStream().Length);
                    string slikaa = Convert.ToBase64String(content);
                    slika.Putanja = slikaa;
                }

                _db.Slike.Add(slika);
                _db.SaveChanges();
            }

            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult Create(Slika slika)
        {
            if (slika.SlikaFajl != null)
            {
                var a = slika.SlikaFajl.OpenReadStream();
                using (BinaryReader br = new BinaryReader(slika.SlikaFajl.OpenReadStream()))
                {
                    byte[] content = br.ReadBytes((int)slika.SlikaFajl.OpenReadStream().Length);
                    string slikaa = Convert.ToBase64String(content);
                    slika.Putanja = slikaa;
                }

                _db.Slike.Add(slika);
                _db.SaveChanges();
            }

            return View();
        }
    }
}
