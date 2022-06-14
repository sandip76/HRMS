using EMS.BLL.EmployeeBll;
using EMS.BLL.MappingProfile;
using EMS.DLL.Context;
using EMS.DLL.EmployeeDll;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace EMS.API
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
            services.AddControllers();
            services.AddMvc();
            _registerDependencyInjection(services);
            services.AddDbContext<EmployeeDbContext>(item => item.UseSqlServer(Configuration.GetConnectionString("myconn")));
            // configuring Automapper for mapping objects
            var config = new AutoMapper.MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            var mapper = config.CreateMapper();
            services.AddSingleton(mapper);
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
        private static void _registerDependencyInjection(IServiceCollection services)
        {
            services.AddTransient<IEmployeeBll, EmployeeBll>();
            services.AddTransient<IEmployeeDll, EmployeeDll>();
            //services.AddTransient(typeof(IGenericDalRepository<>), typeof(GenericDalRepository<>));

            //services.AddTransient(typeof(IGenericRepository<>), typeof(EFCoreGenericRepository<>));
        }
    }
}
