using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnApIUsingEF.Models;
using Microsoft.EntityFrameworkCore;

namespace HandsOnApIUsingEF.Context
{
    public class EmployeeContext:DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext>options):base(options)
        {

        }
        public DbSet<Employee> Employee { get; set; }

        public DbSet<Dept> Depts { get; set; }

        //manage connection strings
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-MFOQ4PM\ANJANI;Database=EmpDB;Trusted_Connection=True;");
        }
    }
}
