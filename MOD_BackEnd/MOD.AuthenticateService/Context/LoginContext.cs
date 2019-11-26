using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MOD.AuthenticateServic.Models;
using MOD.AuthenticateService.Models;

namespace MOD.AuthenticateService.Context
{
    public class LoginContext:DbContext
    {
        public LoginContext(DbContextOptions<LoginContext> options) : base(options)
        {

        }
        public DbSet<Mentor> Mentor { get; set; }

        public DbSet<User> User { get; set; }

        public DbSet<Payment> Payment { get; set; }

        public DbSet<Skill> Skills { get; set; }

        public DbSet<Training> Trainings { get; set; }
    }
}
