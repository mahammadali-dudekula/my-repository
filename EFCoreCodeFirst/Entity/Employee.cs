using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreCodeFirst.Entity
{
    public class Employee
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
    }

    public class EmployeeMapping : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(p => p.Id);
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name);
            builder.Property(p => p.Designation);
            builder.ToTable("T_Elite_Employee");
                   
        }
    }
}
