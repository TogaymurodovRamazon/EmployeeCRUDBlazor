using EmployeeCRUDBlazor.Data;
using Microsoft.EntityFrameworkCore;

namespace EmployeeCRUDBlazor.DBContext
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }
        

        public DbSet<Employees> Employees { get; set; }
    }
}
