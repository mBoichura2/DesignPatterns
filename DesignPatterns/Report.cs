using DesignPatterns;
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

        public void Generate(JournalSP journal)
        {
            journal.AddParams(Date.ToString(), Data[0].GetReading(), Data[1].GetReading(), Data[2].GetReading());
        }
    }
}
