using System.Collections.Generic;
using MOD.TechnologyService.Models;

namespace MOD.TechnologyService.Repositories
{
    public interface ISkillRepository
    {
        void add(Skill Item);
        IEnumerable<Skill> GetAll();
        void Update(Skill item);
        void Delete(string id);

        Skill GetName(string name );
    }
}
