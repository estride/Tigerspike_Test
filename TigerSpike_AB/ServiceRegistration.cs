using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;
using TigerSpike.API;
using TigerSpike.Core;
using TigerSpike.Data;
using TigerSpike.Interface.Data;

namespace TigerSpike.API
{
    public static class ServiceRegistration
    {
        /// <summary>
        /// Injects all of the dependancies
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        public static void Register(this IServiceCollection services, IConfiguration configuration)
        {
            var optsAction = new Action<SqlServerDbContextOptionsBuilder>(opts => opts.CommandTimeout((int)TimeSpan.FromMinutes(10).TotalSeconds));
            services.AddDbContext<TSContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"), optsAction));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddTransient<IMovieDataService, MovieDataService>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Title = "Moviegram API",
                    Version = "v1",
                    Description = "Movie Manager",
                    TermsOfService = "Refer to legal",
                    Contact = new Contact() { Name = "Arpan Bhatia", Email = "arpanbhatia@gmail.com", Url = "www.estride.store" },
                    License = new License() { Name = "License Terms", Url = "www.moviegram.com/license" }
                });

                var xmlFile = $"{System.Reflection.Assembly.GetExecutingAssembly().GetName().Name}.xml";
                c.IncludeXmlComments(System.IO.Path.Combine(AppContext.BaseDirectory, xmlFile));

                c.DescribeAllEnumsAsStrings();
                c.DescribeStringEnumsInCamelCase();
            });


        }
    }
}
