using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Interface;

namespace ConsoleApp1.Models
{
    internal class Dog : Domestic , ISwim
    {

        public Dog(string name) : base(name)
        {
        }

        public override void Eat()
        {
            Console.WriteLine("Eating bone");
        }

        public int MaxSwimTime { get; set; } = 1;
        public void Swim()
        {
            Console.WriteLine("Dog swimed");
        }
    }
}
