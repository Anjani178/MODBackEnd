using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD.AuthenticateServic.Models;
using MOD.AuthenticateService.Models;


namespace MOD.AuthenticateService.Repositories
{
    public interface ILoginRepository
    {
        User UserLogin(string id, string password);
        Mentor MentorLogin(string id, string password);
    }
}
