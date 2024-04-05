using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Bicycle : Vehicle
    {
        private string _type;

        
        public Bicycle(string factory, string model, string color, decimal time, decimal length, string cycleType, string fuel) : base(factory, model, color, time, length, fuel)
        {
            _type = cycleType;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Factory: {FactroyName = "Stels"}, Model: {Model}, Color: {Color}, Type: {_type}");
        }
        public override string ToString()
        {
            return $"Factory Name:{FactroyName}, Model:{Model}";
        }

        public override void DefineNatureHarmness()
        {
            
        }

        public string Type { get { return _type; } set { _type = value; } }


    }
}
