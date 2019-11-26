using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MOD.UserService.Models;

namespace AuthenticationService.Context
{
    public class LoginContext:DbContext    {
        public LoginContext(DbContextOptions<LoginContext> options) : base(options)
        {

        }
        public DbSet<User> User { get; set; }

        public DbSet<Mentor> Mentor { get; set; }
    }
}
