using ASPDotNetCoreMVC_MSSQL_EF_Template.Models;
using ASPDotNetCoreMVC_MSSQL_EF_Template.Repositories;
using ASPDotNetCoreMVC_MSSQL_EF_Template.Services;
using ASPDotNetCoreMVC_MSSQL_EF_Template.Utilities;
using Microsoft.EntityFrameworkCore;

namespace ASPDotNetCoreMVC_MSSQL_EF_Template
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("Msssql")));

            builder.Services.AddScoped<IRepository<Student>, StudentRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
