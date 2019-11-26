using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnApiWithModels.Models;

namespace HandsOnApiWithModels.Repositories
{
    public class EmployeeRepository
    {
        List<Employee> emps;
        public EmployeeRepository()
        {
            emps = new List<Employee>()
            {
                new Employee { Eid=1, Ename = "Anjani", Designation="PAT",Salary=20000,DOJ=DateTime.Parse("29-07-2019")},
                new Employee { Eid=2, Ename = "Nagarjun", Designation="PAT",Salary=21000, DOJ=DateTime.Parse("29-07-2019")},
                new Employee { Eid=3, Ename = "Sarkar", Designation="PA",Salary=19000, DOJ=DateTime.Parse("29-07-2019")},
                new Employee { Eid=4, Ename = "Ankit", Designation="PA",Salary=20000, DOJ=DateTime.Parse("29-07-2019")},
                new Employee { Eid=5, Ename = "Meenakshi", Designation="PAT",Salary=20000, DOJ=DateTime.Parse("29-07-2019")}
            };
        }

        //get all students
        public List<Employee> GetAll()
        {
            return emps;
        }

        //get student by ID
        public Employee GetById(int id)
        {
            return emps.SingleOrDefault(i => i.Eid == id);
            //return (from i in students where i.Sid == id select i).SingleOrDefault();
        }

        public List<Employee> GetBySalary(int sal)
        {
            return emps.Where(i => i.Salary == sal).ToList();  //where . to list for multiple recors to be returned from a query
            //return (from i in students where i.Sid == id select i).SingleOrDefault();
        }

        public List<Employee> GetByDes(string des)
        {
            return emps.Where(i => i.Designation == des).ToList();  //where . to list for multiple recors to be returned from a query
            //return (from i in students where i.Sid == id select i).SingleOrDefault();
        }

        public void Add(Employee item)
        {
            emps.Add(item);
        }
    }
}
