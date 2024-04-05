using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Interface;
using Console = System.Console;

namespace ConsoleApp1.Models
{
    internal class Fish :Animal , ISwim
    {
        public Fish(string name) : base(name)
        {
        }

        public override void Eat()
        {
            
        }

        public int MaxSwimTime { get; set; }
        public void Swim()
        {
            Console.WriteLine("Fish swim");
        }

    }
}
