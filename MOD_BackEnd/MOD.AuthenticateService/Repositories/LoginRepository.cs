using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD.AuthenticateServic.Models;
using MOD.AuthenticateService.Context;
using MOD.AuthenticateService.Models;

namespace MOD.AuthenticateService.Repositories
{
    public class LoginRepository:ILoginRepository
    {
        private readonly LoginContext _context;
        public LoginRepository(LoginContext context)
        {
            _context = context;
        }

        public Mentor MentorLogin(string mid, string password)
        {
            return _context.Mentor.SingleOrDefault(data => data.Mid == mid && data.MPassword == password);
            //if (obj != null)
            //{
            //    return true;
            //}
            //else
            //    return false;
        }

        public User UserLogin(string uid, string password)
        {
            return _context.User.SingleOrDefault(data => data.Uid == uid && data.UPassword == password);
            //if (obj != null)
            //{
            //    return true;
            //}
            //else
            //    return false;
        }
    }
}

