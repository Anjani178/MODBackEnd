using System;
using Assignment1.Context;
using Assignment1.Repositories;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderContext context = new OrderContext();
            OrderRep repository = new OrderRep(context);
        }
    }
}
