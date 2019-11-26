using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD.UserService.Context;
using MOD.UserService.Models;

namespace MOD.UserService.Repositories
{
    public class MentorRepository : IMentorRepository
    {
        private readonly UserContext _context;
        public MentorRepository(UserContext context)
        {
            _context = context;
        }
        public void add(Mentor Item)
        {
            _context.Mentor.Add(Item);
            _context.SaveChanges();
        }

        public void Delete(string id)
        {
            var item = _context.Mentor.Find(id);
            _context.Mentor.Remove(item);
            _context.SaveChanges();
        }

        public Mentor GetById(string id)
        {
            return _context.Mentor.Find(id);
        }
        public IEnumerable<Mentor> GetAll()
        {
            return _context.Mentor.ToList();

        }

        public void ResetPass(string e, string pass)
        {
            var x = _context.Mentor.SingleOrDefault(i => i.MEmail.Equals(e));
            x.MPassword = pass;

            _context.Mentor.Update(x);
            _context.SaveChanges();
        }

        public void Update(Mentor item)
        {
            var x = _context.Mentor.Find(item.Mid);
            x.MEmail = item.MEmail;
            x.Contact = item.Contact;

            _context.Mentor.Update(x);
            _context.SaveChanges();
        }
        public void Block(string id)
        {
            var item = _context.Mentor.Find(id);
            if (item.Active == "True")
            {
                item.Active = "False";
            }
            else
            {
                item.Active = "True";
            }
            _context.Mentor.Update(item);
            _context.SaveChanges();
        }
    }
}
