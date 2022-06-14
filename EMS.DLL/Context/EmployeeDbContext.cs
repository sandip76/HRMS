using EMS.DLL.DataModels;
using Microsoft.EntityFrameworkCore;

namespace EMS.DLL.Context
{
    public class EmployeeDbContext: DbContext
    {
        public EmployeeDbContext(DbContextOptions options) : base(options)
        {
        }

        DbSet<Employee> Employees { get; set; }
    }
}
