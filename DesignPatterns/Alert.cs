using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    // Клас сповіщення
    public class Alert
    {
        public string Message { get; set; }
        public DateTime Timestamp { get; set; }

        public void SendAlert()
        {
            Console.WriteLine($"ALERT! {Message} at {Timestamp}");
        }
    }
}
