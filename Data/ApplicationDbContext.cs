using EmpMVCTask.Models;
using Microsoft.EntityFrameworkCore;

namespace EmpMVCTask.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=ENG-TALA-ISMAIL;database=EmpMVCDB;trusted_connection=true;TrustServerCertificate=True;");
        }
    }
}
