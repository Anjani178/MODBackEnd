using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD.UserService.Models;

namespace MOD.UserService.Repositories
{
    public interface IMentorRepository
    {
        void add(Mentor Item);
        IEnumerable<Mentor> GetAll();
        Mentor GetById(string id);
        void Update(Mentor item);
        void ResetPass(string e,string pass);
        void Delete(string id);

        void Block(string id);
    }
}
