using crudJoin.Models;
using crudJoin.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace crudJoin.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) 
        {
            
        }

        //Model
        public DbSet<EmployeeRegister> EmployeeRegister { get; set; }
        public DbSet<Department> Department { get; set; }

        //ViewModel
        public DbSet<EmployeeDepartmentViewModel> EmployeeDepartmentViewModel { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeDepartmentViewModel>().HasNoKey();
        }

    }
}
