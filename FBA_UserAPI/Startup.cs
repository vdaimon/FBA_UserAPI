using FBA_UserAPI.Controllers;
using Microsoft.EntityFrameworkCore;

namespace FBA_UserAPI
{
    public class Startup
    {
        public Startup(IConfigurationRoot configuration)
        {
            Configuration = configuration;
        }
        public IConfigurationRoot Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            string con = "Host=localhost;Port=5432;Database=FBA_user_db;Username=postgres;Password=password";

            services.AddDbContext<BalanceContext>(options => options.UseNpgsql(con));

            services.AddControllers();

            services.AddCors();

            services.AddSwaggerGen();

        }

        public void Configure(IApplicationBuilder app)
        {

            app.UseDeveloperExceptionPage();

            app.UseSwagger();

            app.UseSwaggerUI();

            app.UseRouting();

            app.UseCors(builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
