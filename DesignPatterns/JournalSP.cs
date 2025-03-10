using DesignPatterns;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class JournalSPMP
    {
        private string[] _time;
        private double[] _tempSensor;
        private double[] _PHMeter;
        private double[] _turbiditySensor;
        private int _counter;
        private static JournalSPMP _journal;//1

        private JournalSPMP()//2
        {
            _time = new string[1000];
            _tempSensor = new double[1000];
            _PHMeter = new double[1000];
            _turbiditySensor = new double[1000];
        }

        public static JournalSPMP GetInstance()//3
        {
            if (_journal == null)
            {
                _journal = new JournalSPMP();
            }
            return _journal;
        }

        public void AddParams(string time, double tempSensor, double PHMeter, double turbiditySensor)
        {
            _time[_counter] = time;
            _tempSensor[_counter] = tempSensor;
            _PHMeter[_counter] = PHMeter;
            _turbiditySensor[_counter] = turbiditySensor;
            _counter = _counter + 1;
        }

        public void PrintParams()
        {
            for (int i = 0; i < _counter; ++i)
            {
                Console.WriteLine(_time[i]);
                Console.WriteLine(_tempSensor[i]);
                Console.WriteLine(_PHMeter[i]);
                Console.WriteLine(_turbiditySensor[i]);
                Console.WriteLine();
            }
        }

        public Memento SaveState()
        {
            var memento = new Memento(_time, _tempSensor, _PHMeter, _turbiditySensor, _counter);
            return memento;
        }

        public void RestoreState(Memento memento)
        {
            _time = memento.Time;
            _tempSensor = memento.TempSensor;
            _PHMeter = memento.PHMeter;
            _turbiditySensor = memento.TurbiditySensor;
            _counter = memento.Counter;
        }
    }
}
