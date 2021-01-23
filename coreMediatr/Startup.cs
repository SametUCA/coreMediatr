using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using coreMediatr.Models;
using coreMediatr.Persistance;
using coreMediatr.Repository;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace coreMediatr
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        private IConfiguration Configuration { get; }

        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IArticle, ArticleRepository>();
            services.AddMediatR(typeof(Startup));
            services.AddDbContext<MediatRContext>(optionsAction => optionsAction.UseInMemoryDatabase("memoryDb"));
            services.AddControllers();
        }

        public static void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });

            using (var service =  app.ApplicationServices.CreateScope())
            {
                var context = service.ServiceProvider.GetService<MediatRContext>();
                context?.Database.EnsureCreated();
            }
        }
    }
}