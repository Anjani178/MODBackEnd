using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD.TechnologyService.Context;
using MOD.TechnologyService.Models;

namespace MOD.TechnologyService.Repositories
{
    public class Skillrepository : ISkillRepository
    {
        private readonly TechnoContext _context;
        public Skillrepository(TechnoContext context)
        {
            _context = context;
        }
        public void add(Skill Item)
        {
            _context.Skills.Add(Item);
            _context.SaveChanges();
        }

        public void Delete(string id)
        {
            var item = _context.Skills.Find(id);
            _context.Skills.Remove(item);
            _context.SaveChanges();
        }

        public IEnumerable<Skill> GetAll()
        {
            return _context.Skills.ToList();
        }

        public Skill GetName(string name)
        {
            return _context.Skills.SingleOrDefault(i => i.SName == name);
        }

        public void Update(Skill item)
        {
            var x = _context.Skills.Find(item.SId);
            x.SName = item.SName;
            x.PreReq = item.PreReq;
            x.Fees = item.Fees;
            x.toc = item.toc;
            x.Duration = item.Duration;

            _context.Skills.Update(x);
            _context.SaveChanges();
        }
    }
}
