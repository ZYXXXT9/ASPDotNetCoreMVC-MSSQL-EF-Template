using ASPDotNetCoreMVC_MSSQL_EF_Template.Models;
using ASPDotNetCoreMVC_MSSQL_EF_Template.Services;
using ASPDotNetCoreMVC_MSSQL_EF_Template.Utilities;
using Microsoft.EntityFrameworkCore;

namespace ASPDotNetCoreMVC_MSSQL_EF_Template.Repositories
{
    public class StudentRepository : IRepository<Student>
    {
        private readonly AppDbContext db;
        public StudentRepository(AppDbContext _db)
        {
            db = _db;
        }
        public async Task<IEnumerable<Student>> GetStudents()
        {
            return await db.Students.ToListAsync();
        }

        public async Task Add(Student _Student)
        {
            await db.Students.AddAsync(_Student);
            await db.SaveChangesAsync();
        }
    }
}
