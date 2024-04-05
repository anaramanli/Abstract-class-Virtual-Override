using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Birds : Animal
    {
        public Birds(string name) : base(name)
        {
        }

        public override void Eat()
        {
            Console.WriteLine("Bird ate wheat");
        }

        public virtual void Fly()
        {
            Console.WriteLine("bird flied");
        }

    }
}
