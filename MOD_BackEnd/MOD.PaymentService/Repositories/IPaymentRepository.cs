using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD.PaymentService.Models;

namespace MOD.PaymentService.Repositories
{
    public interface IPaymentRepository
    {
        void add(Payment Item);
        IEnumerable<Payment> GetAll();
        void Delete(int id);
    }
}
