using CRTBuisnessLogics.Managers.Admin;
using CRTDataAccess.DBContext;
using CRTDataAccess.Managers.Admin;
using CRTWebApi.Model;
using CRTWebApi.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;


namespace CRTWebApi
{
    public class Startup
    {
        private readonly IConfiguration _configuration;
        private readonly IWebHostEnvironment _webHostingEnv;

        public Startup(IConfiguration configuration, IWebHostEnvironment webHostingEnv)
        {
            this._configuration = configuration;
            this._webHostingEnv = webHostingEnv;

        }

        private static void RegisterService(IServiceCollection service)
        {
            // Here we can add Registered Services like 
            service.AddTransient<IMaster, Master>();
            service.AddTransient<ICategoryManager, CategoryManager>();
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDBContext>(option =>
            {
                option.UseSqlServer(_configuration.GetConnectionString("AdminDbConnection"));
            });
            RegisterService(services);
            services.AddControllers();
            services.AddSwaggerGen();

        }

        public void configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseRouting();

            app.UseEndpoints(endpoint =>
            {
                endpoint.MapControllers();
            });

            app.UseSwagger();
            app.UseSwaggerUI(option =>
            {
                option.SwaggerEndpoint("/swagger/v1/swagger.json", "CRTWebApi");
            });

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

        }
    }
}
