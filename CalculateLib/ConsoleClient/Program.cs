using System;
using System.Collections.Generic;
using CalculateLib;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate obj = new Calculate();
            int a = 8;
            int b = 7;
            int c = obj.Add(a, b);
            Console.WriteLine(c);

            string msg = obj.Greet("Anjani");
            Console.WriteLine(msg);

            List<string> list = obj.getNames();
            foreach(var i in list)
            {
                Console.WriteLine(i);
            }


        }
    }
}
