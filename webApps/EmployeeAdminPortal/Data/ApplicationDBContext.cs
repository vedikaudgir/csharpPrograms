using EmployeeAdminPortal.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace EmployeeAdminPortal.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<DbContext> options) : base(options)
        {
            
        }
        public DbSet<Employee> MyProperty { get; set; }
    }
}
