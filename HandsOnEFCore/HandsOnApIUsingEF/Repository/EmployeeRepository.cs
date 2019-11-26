using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnApIUsingEF.Context;
using HandsOnApIUsingEF.Models;

namespace HandsOnApIUsingEF.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeContext _context;
        public EmployeeRepository( EmployeeContext context)
        {
            _context = context;
        }
        public void add(Employee Item)
        {
            _context.Employee.Add(Item);
            _context.SaveChanges();
            
        }

        public void Delete(int id)
        {
            var item = _context.Employee.Find(id);
            _context.Employee.Remove(item);
            _context.SaveChanges();
        }

        public List<Employee> GetAll()
        {
            return _context.Employee.ToList();
            
        }

        public Employee GetById(int id)
        {
            // return _context.Employee.SingleOrDefault(i => i.Eid == id);
            return _context.Employee.Find(id);
            
        }

        public void Update(Employee item)
        {
            var x = _context.Employee.Find(item.Eid);
            x.Desig = item.Desig;
            x.Ename = item.Ename;
            x.Did = item.Did;
            x.JoinDate = item.JoinDate;
            x.Sal = item.Sal;

            _context.Employee.Update(x);
            _context.SaveChanges();

        }
    }
}
