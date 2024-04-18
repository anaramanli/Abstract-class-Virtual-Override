using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Domestic : Animal
    {
        public Domestic(string name) : base(name)
        {
        }

        public Domestic()
        {
            
        }
        public override void Eat()
        {
            Console.WriteLine("Being Pet");
        }
    }
}
