using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    // Абстрактний клас сенсора, що реалізує інтерфейс
    public abstract class Sensor : AbstractDevice, IDataProcessor
    {
        public string Name { get; set; }
        public double Value { get; protected set; }

        public abstract void Calibrate();
        public abstract double GetReading();

        // Реалізація інтерфейсу IDataProcessor
        public void ProcessData()
        {
            Console.WriteLine($"Processing data from {Name}");
        }

        public override void Connect()
        {
            Console.WriteLine($"{Name} connected.");
        }

        public override void Disconnect()
        {
            Console.WriteLine($"{Name} disconnected.");
        }
    }
}
