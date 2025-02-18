using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class TurbiditySensor : Sensor
    {
        public override void Calibrate() => Console.WriteLine("Calibrating turbidity sensor...");
        public override double GetReading()
        {
            Value = new Random().NextDouble() * 10;
            return Value;
        }
    }
}
