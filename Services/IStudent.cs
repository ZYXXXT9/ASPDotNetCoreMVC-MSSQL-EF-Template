using ASPDotNetCoreMVC_MSSQL_EF_Template.Models;

namespace ASPDotNetCoreMVC_MSSQL_EF_Template.Services
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetStudents();
        Task Add(Student _Student);
    }
}
