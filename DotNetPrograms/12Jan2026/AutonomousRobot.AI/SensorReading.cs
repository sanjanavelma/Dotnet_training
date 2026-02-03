using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
public class SensorReading
    {
        public int SensorId{get; set;}
        public string Type{get; set;}
        public double Value{get; set;}
        public DateTime Timestamp{get; set;}
        public double Confidence{get; set;}
    }
    public enum RobotAction
    {
        Stop,
        SlowDown,
        Reroute,
        Continue
    }
    public class DecisionEngine
    {
        public static List<SensorReading> GetRecentReadings(List<SensorReading> sensorHistory, DateTime fromTime)
        {
            return sensorHistory.Where(r => r.Timestamp >= fromTime).ToList();
        }
        public static bool IsBatteryCritical(List<SensorReading> sensorHistory)
        {
            return sensorHistory.Any(r => r.Type == "Battery" && r.Value < 20);
        }
        public static double GetNearestObstacleDistance(List<SensorReading> sensorHistory)
        {
            return sensorHistory.Where(r => r.Type == "Distance").Select(r => r.Value).DefaultIfEmpty(double.MaxValue).Min();
        }
        public static bool IsTemperatureSafe(List<SensorReading> sensorHistory)
        {
            return sensorHistory.Where(r => r.Type == "Temperature").All(r => r.Value < 90);
        }
        public static double GetAverageVibration(List<SensorReading> sensorHistory)
        {
            return sensorHistory.Where(r => r.Type == "Vibration").Average(r => r.Value);
        }
        public static Dictionary<string, double> CalculateSensorHealth(List<SensorReading> sensorHistory)
        {
            return sensorHistory.GroupBy(r => r.Type).ToDictionary(g => g.Key, g => g.Average(r => r.Confidence));
        }
        public static List<string> DetectFaultySensors(List<SensorReading> sensorHistory)
        {
            return sensorHistory.GroupBy(r => r.Type).Where(g => g.Count(r => r.Confidence < 0.4) > 2).Select(g => g.Key).ToList();
        }
        // public static bool isBatteryDrainingFast(List<SensorReading> sensorHistory)
        // {
        //     return 
        // }
        public static double GetWeightDistance(List<SensorReading> sensorHistory)
        {
            var distanceReading = sensorHistory.Where(r => r.Type == "Distance");
            double WeightedSum = distanceReading.Sum(r => r.Value * r.Confidence);
            double TotalConfidence = distanceReading.Sum(r => r.Confidence);
            return TotalConfidence == 0? double.MaxValue : WeightedSum / TotalConfidence;
        }
        public static RobotAction DecideRobotAction(
            List<SensorReading> sensorHistory,
            List<SensorReading> recentReadingss)
        {
            // Rule 1: Critical Battery Condition
            if (recentReadingss.Any(r => r.Type == "Battery" && r.Value < 20))
            {
                return RobotAction.Stop;
            }
            // Rule 2: Rapid Battery Drain Condition
            if (IsBatteryCritical(sensorHistory))
            {
                return RobotAction.Stop;
            }
            // Rule 3: Obstacle Proximity Condition
            double nearestDistance = GetNearestObstacleDistance(recentReadingss);
            if (nearestDistance < 1.0)
            {
                return RobotAction.Reroute;
            }
            // Rule 4: Temperature Safety Condition
            if (recentReadingss.Any(r => r.Type == "Temperature" && r.Value >= 90))
            {
                return RobotAction.SlowDown;
            }
            // Rule 5: Default Safe Operation
            return RobotAction.Continue;
        }
    }
