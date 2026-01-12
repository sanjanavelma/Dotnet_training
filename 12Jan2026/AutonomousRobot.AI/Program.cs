using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        List<SensorReading> sensorHistory = new List<SensorReading>
        {
            new SensorReading{SensorId = 1, Type = "Distance", Value = 0.8, Timestamp = DateTime.Now.AddSeconds(-30), Confidence = 0.9},
            new SensorReading { SensorId = 2, Type = "Battery", Value = 44.0, Timestamp = DateTime.Now.AddSeconds(-20), Confidence = 0.8 },
            new SensorReading { SensorId = 3, Type = "Temperature", Value = 61.1, Timestamp = DateTime.Now.AddSeconds(-15), Confidence = 0.7 },
            new SensorReading { SensorId = 4, Type = "Vibration", Value = 8.0, Timestamp = DateTime.Now.AddSeconds(-9), Confidence = 0.6},
            new SensorReading { SensorId = 5, Type = "Vibration", Value = 7.5, Timestamp = DateTime.Now.AddSeconds(-5), Confidence = 0.9},
            new SensorReading { SensorId = 6, Type = "Distance", Value = 2.5, Timestamp = DateTime.Now, Confidence = 0.5 }
        };
        DateTime fromTime = DateTime.Now.AddSeconds(-10);
        var recentReadings = DecisionEngine.GetRecentReadings(sensorHistory, fromTime);
        Console.WriteLine("Recent Readings: ");
        foreach(var reading in recentReadings)
        {
            Console.WriteLine($"Sensor {reading.SensorId} | Value: {reading.Value} | Time: {reading.Timestamp}");
        }
        bool IsCritical = DecisionEngine.IsBatteryCritical(sensorHistory);
        Console.WriteLine($"Battery Critical: {IsCritical}");
        bool highTemp = DecisionEngine.IsTemperatureSafe(sensorHistory);
        Console.WriteLine($"Temperatur is Safe: {highTemp}");
        double AvgVib = DecisionEngine.GetAverageVibration(sensorHistory);
        Console.WriteLine($"Average of Vibration: {AvgVib}");
        var health = DecisionEngine.CalculateSensorHealth(sensorHistory);
        Console.WriteLine("---Average of Confidence of every Group---");
        foreach (var h in health)
        {
            Console.WriteLine($"{h.Key} -> {h.Value}");
        }
        var FaultySensors = DecisionEngine.DetectFaultySensors(sensorHistory);
        Console.WriteLine($"[{string.Join(",", FaultySensors)}]");
        double WeightedDistance = DecisionEngine.GetWeightDistance(sensorHistory);
        Console.WriteLine("Confidence-Weighted obstacle distance: " + WeightedDistance);
        
        List<SensorReading> recentReadingss = sensorHistory;
        RobotAction action = DecisionEngine.DecideRobotAction(
            sensorHistory,
            recentReadingss
        );
        Console.WriteLine(action);
    }
}