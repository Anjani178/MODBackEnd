using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnApIUsingEF.Models;

namespace HandsOnApIUsingEF.Repository
{
    public interface IEmployeeRepository
    {
        void add(Employee Item);
        List<Employee> GetAll();
        Employee GetById(int id);
        void Update(Employee item);
        void Delete(int id);
    }
}
