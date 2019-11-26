using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnApiWithModels.Models;

namespace HandsOnApiWithModels.Repositories
{
    public class StudentRepository
    {
        List<Student> students;
        public StudentRepository()
        {
            students = new List<Student>()
            {
                new Student { Sid=1, Sname = "Anjani", Class="I",age=12},
                new Student { Sid=2, Sname = "Nagarjun", Class="II",age=10},
                new Student { Sid=3, Sname = "Sarkar", Class="I",age=15},
                new Student { Sid=4, Sname = "Ankit", Class="II",age=13},
                new Student { Sid=1, Sname = "Meenakshi", Class="III",age=18}
            };
        }

        //get all students
        public List<Student> GetAll()
        {
            return students;
        }

        //get student by ID
        public Student GetById(int id)
        {
            return students.SingleOrDefault(i => i.Sid == id);
            //return (from i in students where i.Sid == id select i).SingleOrDefault();
        }

        public List<Student> GetByAge(int a)
        {
            return students.Where(i => i.age == a).ToList();  //where . to list for multiple recors to be returned from a query
            //return (from i in students where i.Sid == id select i).SingleOrDefault();
        }

        public void Add(Student item)
        {
            students.Add(item);
        }
    }
}
