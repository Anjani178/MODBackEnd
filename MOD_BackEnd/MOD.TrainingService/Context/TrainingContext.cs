using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MOD.TrainingService.Models;

namespace MOD.PaymentService.Context
{ 
        public class TrainingContext : DbContext
        {
            public TrainingContext(DbContextOptions<TrainingContext> options) : base(options)
            {

            }
        public DbSet<Mentor> Mentor { get; set; }

        public DbSet<User> User { get; set; }

        public DbSet<Payment> Payment { get; set; }

        public DbSet<Skill> Skills { get; set; }

        public DbSet<Training> Trainings { get; set; }
    }
}
