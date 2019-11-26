using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD.UserService.Context;
using MOD.UserService.Models;

namespace MOD.UserService.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UserContext _context;
        public UserRepository(UserContext context)
        {
            _context = context;
        }
        public void add(User Item)
        {
            _context.User.Add(Item);
            _context.SaveChanges();
        }
        public IEnumerable<User> GetAll()
        {
            return _context.User.ToList();

        }
        public void Delete(string id)
        {
            var item = _context.User.Find(id);
            _context.User.Remove(item);
            _context.SaveChanges();
        }

        public User GetById(string id)
        {
            return _context.User.Find(id);
        }

        public void ResetPass(string e,string pass)
        {
            var x = _context.User.SingleOrDefault(i=>i.UEmail.Equals(e));
            x.UPassword = pass;

            _context.User.Update(x);
            _context.SaveChanges();
        }

        public IEnumerable<Mentor> SearchMentor(string Tech,string TSlot )
        {
            var res = _context.Mentor.Where(j => j.Technologies == Tech || j.TimeSlot == TSlot);
            return res;
        }

        public void Update(User item)
        {
            var x = _context.User.Find(item.Uid);
            x.UEmail = item.UEmail;
            x.Contact = item.Contact;

            _context.User.Update(x);
            _context.SaveChanges();
        }
        public void Block(string id)
        {
            var item = _context.User.Find(id);
            if (item.Active == "True")
            {
                item.Active = "False";
            }
            else
            {
                item.Active = "True";
            }
            _context.User.Update(item);
            _context.SaveChanges();
        }

    }
}
