using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    // Конкретні сенсори
    public class TemperatureSensor : Sensor
    {
        public override void Calibrate() => Console.WriteLine("Calibrating temperature sensor...");
        public override double GetReading()
        {
            Value = new Random().NextDouble() * 100;
            return Value;
        }
    }
}
