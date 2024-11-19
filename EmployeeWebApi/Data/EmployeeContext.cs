using EmployeeWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeWebApi.Data
{
    public class EmployeeContext:DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {

        }
    }
}
