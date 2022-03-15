using Microsoft.EntityFrameworkCore;
using MySqlApiDemo.Models;

namespace MySqlApiDemo.Data
{
    public class MySqlDbContext:DbContext
    {
        public MySqlDbContext(DbContextOptions<MySqlDbContext> options): base(options)
        {

        }

        public DbSet<Person> Persons { get; set; }
    }
}
