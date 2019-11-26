using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateLib
{
    public class Calculate
    {
        public int Add(int a,int b)
        {
            return a + b;
        }
        public String Greet(String name)
        {
            return "hello" + name;
        }
        public List<String> getNames()
        {
            return new List<string>(){
                "Rohan","Karan","Jeson"
            };
        }
    }
}
