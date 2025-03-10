using DesignPatterns;
using DesignPatterns;
using System;
using System.Collections.Generic;

// Головна функція для тестування
partial class Program
{
    static void Main()
    {
        WaterQualitySystem system = new WaterQualitySystem();

        Sensor tempSensor = new TemperatureSensor { Name = "TempSensor1" };
        Sensor phSensor = new PHMeter { Name = "PHMeter1" };
        Sensor turbiditySensor = new TurbiditySensor { Name = "TurbiditySensor1" };

        system.AddSensor(tempSensor);
        system.AddSensor(phSensor);
        system.AddSensor(turbiditySensor);
        Console.WriteLine();

        User user = new RegularUser { Name = "User1" };

        JournalSPMP journal = JournalSPMP.GetInstance();
        Caretaker history = new Caretaker();


        QualityCheckFP qualityCheckFP = new QualityCheckFP();
        qualityCheckFP.Check(user, system);

        history.Memento = journal.SaveState();

        qualityCheckFP.Check(user, system);

        journal.RestoreState(history.Memento);

        journal.PrintParams();
    }
}