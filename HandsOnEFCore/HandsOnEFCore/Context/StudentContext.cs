using System;
using System.Collections.Generic;
using System.Text;
using HandsOnEFCore_CodeFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace HandsOnEFCore_CodeFirst.Context
{
    class StudentContext :DbContext
    {
        //dbsets
        public DbSet <Student> Students { get; set; }

        public DbSet<Employee>Employee { get; set; }

        public DbSet<Dept> Depts { get; set; }

        //manage connection strings
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-MFOQ4PM\ANJANI;Database=School;Trusted_Connection=True;");
        }
    }
}