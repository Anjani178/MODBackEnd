using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MOD.UserService.Models;

namespace MOD.UserService.Context
{
    public class UserContext:DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {

        }
        public DbSet<Mentor> Mentor { get; set; }

        public DbSet<User> User { get; set; }

        public DbSet<Payment> Payment { get; set; }

        public DbSet<Skill> Skills { get; set; }

        public DbSet<Training> Trainings { get; set; }


        //manage connection strings
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-MFOQ4PM\MOD;Database=MODDB;Trusted_Connection=True;");
        }
    }
}
