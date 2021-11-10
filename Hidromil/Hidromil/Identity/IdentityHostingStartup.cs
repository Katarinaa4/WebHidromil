using Hidromil.Data;
using Hidromil.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


//[assembly: HostingStartup(typeof(Hidromil.Identity.IdentityHostingStartup))]
namespace Hidromil.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<ApplicationDBContext>(optionsAction: options =>
               options.UseSqlServer(
                   context.Configuration.GetConnectionString(name: "DefaultConnection")));
                services.AddDefaultIdentity<Admin>(configureOptions: options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDBContext>();
            });

        }
    }
}
