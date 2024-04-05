using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Car : Vehicle
    {
        private int _doorCount;
        private bool _isElectricCar;

        public Car(string factory, string model, string color, decimal time, decimal length, int doorCount, bool isElectric, string fuel) : base(factory, model, color, time, length,fuel )
        {
            _doorCount = doorCount;
            _isElectricCar = isElectric;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Factory Name: {FactroyName}, Model: {Model}, Color: {Color}, Time: {DriveTime}, Length: {DrivePath}, Door: {DoorCount=4}, Electric? {IsElectricCar}");
        }
        protected virtual int doorCount { get; } = 4;
            
        public override string ToString()
        {
            return $"Factory Name:{FactroyName}, Model:{Model}";
        }

        public override void DefineNatureHarmness()
        {
            if (IsElectricCar == _isElectricCar)
            {
                Console.WriteLine("Low");
            }
        }

        public int DoorCount
        {
            get => _doorCount;
            set => _doorCount = value;
        }

        public bool IsElectricCar
        {
            get => _isElectricCar;
            set => _isElectricCar = value;
        }

    }
}
