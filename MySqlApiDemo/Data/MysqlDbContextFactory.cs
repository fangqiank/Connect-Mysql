using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace MySqlApiDemo.Data
{
    public class MysqlDbContextFactory: IDesignTimeDbContextFactory<MySqlDbContext>
    {
        public MySqlDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MySqlDbContext>();
            optionsBuilder.UseMySQL("server=localhost;database=library;user=user;password=password");

            return new MySqlDbContext(optionsBuilder.Options);
        }
    }
}
