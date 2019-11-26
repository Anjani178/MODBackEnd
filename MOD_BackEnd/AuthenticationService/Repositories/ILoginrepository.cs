using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD.UserService.Models;

namespace AuthenticationService.Repositories
{
    public interface ILoginrepository
    {
            User UserLogin(string id, string password);
            Mentor MentorLogin(string id, string password);
    }
}
