using System;
using System.Collections.Generic;
using System.Text;
using Assignment1.Context;

namespace Assignment1.Repositories
{
    class OrderRep
    {
        public OrderContext _context;
        public OrderRep(OrderContext context)
        {
            _context = context;
        }
    }
}
