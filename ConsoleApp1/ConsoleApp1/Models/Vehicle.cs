using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    abstract class Vehicle
    {
        private string _factoryName;
        private string _model;
        private string _color;
        private decimal _driveTime;
        private decimal _drivePath;
        private string _fuel;

        public Vehicle(string factory, string model, string color, decimal time, decimal length, string fuel)
        {
             _factoryName = factory;
            _model = model;
            _color = color;
            _driveTime = time;
            _drivePath = length;
            _fuel = fuel;
        }

        public void harm()
        {
            while (true)
            {
                switch (_fuel)
                {
                    case "benzin":
                        Console.WriteLine($"The fuel is {_fuel} and impact is: High");
                        break;
                    case "electric":
                        Console.WriteLine($"The fuel is {_fuel} and impact is:low");
                        break;
                    case "none":
                        Console.WriteLine($"The fuel is {_fuel} and impact is:none");
                        break;
                    default:
                        Console.WriteLine($"The fuel is {_fuel} and impact is:Wrong fuel type");
                        break;
                }
                return;
            }
        }
        
        public void AverageSpeed()
        {
            decimal Avg = (decimal)DrivePath / DriveTime;
            Console.WriteLine($"Your Avarage Speed is : {Avg} km/h");
        }

        public virtual void GetInfo()
        {
            Console.WriteLine($"Factory Name: {FactroyName=="XXX"}, Model: {Model=="XXX"}, Color: {Color=="Grey"}, Time: {DriveTime}, Length: {DrivePath}");
        }
        public override string ToString()
        {
            return $"Factory Name:{FactroyName}, Model:{Model}";
        }

        public abstract void DefineNatureHarmness();
        
        public string FactroyName
        {
            get => _factoryName;
            set => _factoryName = value;
        }

        public string Model
        {
            get => _model;
            set => _model = value;
        }

        public string Color
        {
            get => _color;
            set
            {
                if (value.Length > 3 && value.Length < 25)
                {
                    _color = value;
                }
            }
        }

        public decimal DriveTime
        {
            get => _driveTime;
            set
            {
                if (value > 0)
                {
                    _driveTime = value;
                }
            }
        }

        public decimal DrivePath
        {
            get => _drivePath;
            set
            {
                if (_drivePath> 0)
                {
                    _drivePath = value;
                }
            }
        }
    }
}
