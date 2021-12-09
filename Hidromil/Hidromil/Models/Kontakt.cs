using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hidromil.Models
{
    public class Kontakt
    {
        [Key]
        public int Id { get; set; }
        [BindProperty]
        public String Email { get; set; }
        [BindProperty]
        public String MobilniBr { get; set; }
        [BindProperty]
        public String FiksniBr { get; set; }
        public String Napomena { get; set; } 
    }
}
