using System;
using HandsOnEFCore_CodeFirst.Context;
using HandsOnEFCore_CodeFirst.Models;
using HandsOnEFCore_CodeFirst.Repository;

namespace HandsOnEFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentContext context = new StudentContext();
            StudentRepository repository = new StudentRepository(context);
            try
            {
                //Student obj = new Student();
                //{
                //        Name = "Rohan",
                //        Age = 13,
                //        Class = "II",
                //        School = "PPS"
                //    };
                //repository.Add(obj);

                Student obj = repository.GetById(2);
                if (obj != null)
                {
                    Console.WriteLine("{0} {1}", obj.Name, obj.Class);
                }
                else
                {
                    Console.WriteLine("Invalid Id");
                }

                //check delete
                repository.Delete(3);

                //check Update

                Student obj1 = repository.GetById(1);
                obj1.Age = 12;
                repository.update(obj1);

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    }

