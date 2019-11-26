using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthenticationService.Context;
using MOD.UserService.Models;

namespace AuthenticationService.Repositories
{
    public class LoginRepository : ILoginrepository
    {
        private readonly LoginContext _context;
        public LoginRepository(LoginContext context)
        {
            _context = context;
        }
        public Mentor MentorLogin(string mid, string password)
        {
            return _context.Mentor.SingleOrDefault(data => data.Mid == mid && data.MPassword== password);
        }

        public User UserLogin(string uid, string password)
        {
            return _context.User.SingleOrDefault(data => data.Uid == uid && data.UPassword == password);
        }
    }
}
