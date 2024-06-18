using ASPDotNetCoreMVC_MSSQL_EF_Template.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPDotNetCoreMVC_MSSQL_EF_Template.Utilities
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
    }
}
