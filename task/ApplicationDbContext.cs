using Microsoft.EntityFrameworkCore;
using task.Models;

namespace task;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<EmployeeDetails> employee_details { get; set; }
    public DbSet<EmployeeAddress> Employee_Addresses { get; set; }


}
