using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace LeerData
{
    public class LibroDbContext : DbContext
    {
        private const string connectionString = @"Data Source=DESKTOP-QLDM1DJ\SQLEXP19; Initial Catalog=LibrosWeb; Integrated Security=true";

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Libro> Libro { set; get; }
    }
}