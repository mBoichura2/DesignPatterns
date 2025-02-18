using DesignPatterns;
using Lab1;
using System;
using System.Collections.Generic;

// Головна функція для тестування
class Program
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

        User admin = new AdminUser { Name = "Admin1" };
        User user = new RegularUser { Name = "User1" };

        admin.Login();
        user.Login();
        Console.WriteLine();

        JournalSP journal = JournalSP.GetInstance();
        for (int i = 0; i < 10; i++)
        {
            system.GenerateReport(journal);
        }

        journal.PrintParams();



        JournalSP journal2 = JournalSP.GetInstance();
        for (int i = 0; i < 10; i++)
        {
            system.GenerateReport(journal2);
        }

        journal2.PrintParams();
    }
}