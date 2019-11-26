using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOnApiWithModels.Models
{
    public class Employee
    {
        public int Eid { get; set; }
        public string Ename { get; set; }
        public string Designation  { get; set; }
        public int Salary { get; set; }
        public DateTime DOJ { get; set; }
    }
}
