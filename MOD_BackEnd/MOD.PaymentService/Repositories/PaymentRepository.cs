using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD.PaymentService.Context;
using MOD.PaymentService.Models;

namespace MOD.PaymentService.Repositories
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly PaymentContext _context;
        public PaymentRepository(PaymentContext context)
        {
            _context = context;
        }
        public void add(Payment Item)
        {
            _context.Payment.Add(Item);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var item = _context.Payment.Find(id);
            _context.Payment.Remove(item);
            _context.SaveChanges();
        }

        public IEnumerable<Payment> GetAll()
        {
            return _context.Payment.ToList();
        }
    }
}
