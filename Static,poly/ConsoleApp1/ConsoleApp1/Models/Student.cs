using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Student
    {
        public string Name { get; set; }
        public static void SayHi(string name)
        {
            Console.WriteLine("Salam " + name);
            Console.WriteLine("Salam");
        }

        static Student()
        {
            Console.WriteLine("Static ctor");
        }

        public Student()
        {
            Console.WriteLine("Normal ctor");
        }
        /*static class Person : Student();*/
       

    }
}
