using Microsoft.EntityFrameworkCore;
using PostgresqlDemo.Models;

namespace PostgresqlDemo.Data
{
    public interface IDataContext
    {
        DbSet<Department> Departments { get; set; }
        DbSet<Employee> Employees { get; set; }
    }
}