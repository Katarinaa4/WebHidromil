using Hidromil.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Hidromil.Data
{
    public class ApplicationDBContext : IdentityDbContext<Admin>
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) :base(options)
        {

        }

        public DbSet<Slika> Slike { get; set; }

        //public DbSet<Admin> Admin { get; set; }
    }
}
