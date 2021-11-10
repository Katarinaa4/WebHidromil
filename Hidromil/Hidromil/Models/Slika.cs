using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hidromil.Models
{
    public class Slika
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Image")]
        public String Putanja { get; set; }
        [NotMapped]
        [BindProperty]
        public IFormFile SlikaFajl { get; set; }
    }
}
