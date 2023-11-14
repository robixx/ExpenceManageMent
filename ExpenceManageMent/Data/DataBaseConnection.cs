using ExpenceManageMent.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpenceManageMent.Data
{
    public class DataBaseConnection : DbContext
    {

        public DataBaseConnection(DbContextOptions<DataBaseConnection> options) : base(options)
        {
        }

        public DbSet<Category> Category { get; set; }
        public DbSet<ExpenceManagement> ExpenceManagement { get; set; }

    }
}
