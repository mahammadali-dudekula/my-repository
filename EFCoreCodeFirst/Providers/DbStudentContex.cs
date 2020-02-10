using EFCoreCodeFirst.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreCodeFirst.Providers
{
    public class DbStudentContex:DbContext
    {
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=LAPTOP-T2BEP38Q\SQLEXPRESS;initial catalog=StudentDataBase;integrated security=True;MultipleActiveResultSets=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>();
            modelBuilder.ApplyConfiguration(new EmployeeMapping());
            
        }
    }
}
