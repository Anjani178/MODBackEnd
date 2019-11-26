using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MOD.PaymentService.Context;
using MOD.TrainingService.Models;

namespace MOD.TrainingService.Repositories
{
    public class TrainingRepository : ITrainingRepository
    {
        private readonly TrainingContext _context;
        public TrainingRepository(TrainingContext context)
        {
            _context = context;
        }
        public void add(Training Item)
        {
            _context.Trainings.Add(Item);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var item = _context.Trainings.Find(id);
            _context.Trainings.Remove(item);
            _context.SaveChanges();
        }

        public IEnumerable<Training> GetAll()
        {
            return _context.Trainings.ToList();
        }

        public void UpdateR(Training item)
        {
            _context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();

        }
    }
}
