using DesignPatterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    // Головний клас системи
    public class WaterQualitySystem
    {
        private List<Sensor> Sensors = new List<Sensor>();
        private List<User> Users = new List<User>();

        public void AddSensor(Sensor sensor)
        {
            Sensors.Add(sensor);
            Console.WriteLine($"Sensor {sensor.Name} added.");
        }

        public void RemoveSensor(Sensor sensor)
        {
            Sensors.Remove(sensor);
            Console.WriteLine($"Sensor {sensor.Name} removed.");
        }

        public void GenerateReport(JournalSP journal)
        {
            var report = new Report { Date = DateTime.Now, Data = new List<Sensor>(Sensors) };
            report.Generate(journal);
        }

        public void SendAlert(string message)
        {
            var alert = new Alert { Message = message, Timestamp = DateTime.Now };
            alert.SendAlert();
        }
    }
}
