using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Wild : Animal
    {
        public Wild(string name) : base(name)
        {
        }

        public override void Eat()
        {
            Console.WriteLine("Wild animal eating meat");
        }

    }
}
