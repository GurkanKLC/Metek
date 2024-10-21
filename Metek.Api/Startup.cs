using Metek.Api.Extensions;
using Metek.Application.Features.Mesai.Commands.Create;
using Metek.Application.Services;
using Metek.Application.Services.Repositories;
using Metek.Persistence.Contexts;
using Metek.Persistence.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System.Reflection;

namespace Metek.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {

            Configuration = configuration;

        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddCors(options =>
            {
                options.AddPolicy("AllowAllOrigins",
                    builder =>
                    {
                        builder.AllowAnyOrigin()
                               .AllowAnyMethod()
                               .AllowAnyHeader();
                    });
            });

            // MSSQL Connection String
            var connectionString = Configuration.GetConnectionString("DefaultConnection");

            // Register Swagger
            services.AddSwaggerGen(c =>
            {

                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });

            });

         
            // Register DbContext
            services.AddDbContext<BaseDbContext>(options =>
            options.UseSqlServer(connectionString));
            services.AddScoped<ShiftCalculatorService>();
            services.AddAutoMapperServices();
            services.AddMediaTrServices();

            // Register Repository
            services.AddScoped<IMesaiRepository, MesaiRepository>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseCors("AllowAllOrigins");

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Swagger");
            });

            // Redirect root URL to Swagger UI
            app.MapWhen(context => context.Request.Path == "/", builder =>
            {
                builder.Run(async context =>
                {
                    context.Response.Redirect("/swagger", permanent: true);
                });
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
