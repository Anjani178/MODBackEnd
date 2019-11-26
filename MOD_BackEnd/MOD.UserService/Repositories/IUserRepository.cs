using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD.UserService.Models;

namespace MOD.UserService.Repositories
{
    public interface IUserRepository
    {
        void add(User Item);
        IEnumerable<Mentor> SearchMentor(string Tech,string TSlot);
        IEnumerable<User> GetAll();
        User GetById(string id);
        void Update(User item);
        void ResetPass(string e,string pass);
        void Delete(string id);
        void Block(string id);
    }
}
