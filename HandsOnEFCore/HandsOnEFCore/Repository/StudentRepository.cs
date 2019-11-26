using System;
using System.Collections.Generic;
using System.Text;
using HandsOnEFCore_CodeFirst.Context;
using HandsOnEFCore_CodeFirst.Models;

namespace HandsOnEFCore_CodeFirst.Repository
{
    class StudentRepository
    {
        public StudentContext _context;
        public StudentRepository(StudentContext context)
        {
            _context = context;
        }
        public void Add(Student item) {
            using (StudentContext db = new StudentContext())
            {
                db.Add(item);
                db.SaveChanges();
            }
        }
        public IEnumerable<Student> GetAll()
        {
            return _context.Students;
        }
        public Student GetById(int id)
        {
            return _context.Students.Find(id);
        }
        public void Delete (int id)
        {
            var obj = _context.Students.Find(id);
            _context.Students.Remove(obj);
            _context.SaveChanges();
        }
        public void update (Student item)
        {
            var obj = _context.Students.Find(item.ID);
            obj.School = item.School;
            obj.Age = item.Age;
            //_context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified; Dis
            _context.Update(obj);
            //disconnected
            _context.SaveChanges();
        }
    } }

