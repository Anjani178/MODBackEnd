using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MOD.TechnologyService.Models;

namespace MOD.TechnologyService.Context
{
    public class TechnoContext :DbContext
    {
        public TechnoContext(DbContextOptions<TechnoContext> options) : base(options)
        {

        }
        public DbSet<Mentor> Mentor { get; set; }

        public DbSet<User> User { get; set; }

        public DbSet<Payment> Payment { get; set; }

        public DbSet<Skill> Skills { get; set; }

        public DbSet<Training> Trainings { get; set; }

        //manage connection strings
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=DESKTOP-MFOQ4PM\ANJANI;Database=MODDB;Trusted_Connection=True;");
        //}
    }
}
