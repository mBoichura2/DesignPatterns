using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class PHMeter : Sensor
    {
        public override void Calibrate() => Console.WriteLine("Calibrating pH meter...");
        public override double GetReading()
        {
            Value = new Random().NextDouble() * 14;
            return Value;
        }
    }
}
