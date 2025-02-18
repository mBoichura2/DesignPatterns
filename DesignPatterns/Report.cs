using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    // Клас звіту
    public class Report
    {
        public DateTime Date { get; set; }
        public List<Sensor> Data { get; set; }

        public void Generate()
        {
            Console.WriteLine($"Generating report for {Date}");

            Console.WriteLine($"{Data[0].Name}: {Data[0].GetReading()}");
            Console.WriteLine($"{Data[1].Name}: {Data[1].GetReading()}");
            Console.WriteLine($"{Data[2].Name}: {Data[2].GetReading()}");
        }
    }
}
