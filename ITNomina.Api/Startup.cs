
using ITNomina.Core.Interfaces;
using ITNomina.Infraestructura.Repositorio;
using ITNomina.Infraestructura.Datos;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using System;
using ITNomina.Infraestructura.Filtros;
using FluentValidation.AspNetCore;

namespace ITNomina.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Inyectar los servicios del repositorio génerico
            //services.AddScoped<IUnitOfWork, UnitOfWork>();

            //services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));
            //services.AddScoped(typeof(IRepositorioGenerico<>), typeof(RepositorioGenerico<>));

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddScoped<ICompaniaRepositorio, CompaniaRepositorio>();

            services.AddDbContext<ITNominaContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("ITConeccion")));

            services.AddControllers().AddNewtonsoftJson(options => 
            {
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            })
                //.ConfigureApiBehaviorOptions(options => { options.SuppressModelStateInvalidFilter = true; })
                ; 

            // ESTE TIPO DE SERVICIO DE FILTRADO PARA VALIDACIÓN DEL MODELO YA VIENE IMPLICITO CUANDO 
            // DECORAMOS EL CONTROLADOR CON [ApiController], ASÍ QUE PODEMOS NO IMPLEMENTARLO
            services.AddMvc(options =>
            {
                options.Filters.Add<FiltrosDeValidacion>();
            })
                .AddFluentValidation(options =>
                {
                    options.RegisterValidatorsFromAssemblies(AppDomain.CurrentDomain.GetAssemblies());
                });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

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
