using DesignPatterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    // Клас звіту
    public class Report
    {
        public DateTime Date { get; set; }
        public List<Sensor> Data { get; set; }

        public void Generate(JournalSPMP journal)
        {
            journal.AddParams(Date.ToString(), Data[0].GetReading(), Data[1].GetReading(), Data[2].GetReading());
        }
    }
}
