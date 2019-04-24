using System;
using DecouvrirAspNetCore_MVC.Areas.Identity.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(DecouvrirAspNetCore_MVC.Areas.Identity.IdentityHostingStartup))]
namespace DecouvrirAspNetCore_MVC.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<DecouvrirAspNetCore_MVCIdentityDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("DecouvrirAspNetCore_MVCIdentityDbContextConnection")));

                services.AddDefaultIdentity<IdentityUser>()
                    .AddDefaultUI(UIFramework.Bootstrap4)
                    .AddEntityFrameworkStores<DecouvrirAspNetCore_MVCIdentityDbContext>();
            });
        }
    }
}