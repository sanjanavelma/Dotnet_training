using System;
using System.Collections.Generic;
public abstract class Trade
    {
        public int TradeId{get; set;}
        public string StockSymbol{get; set;}
        public double Quantity;
        public double Price;
        public abstract double TradeValue();

}
public class EquityTrade : Trade
    {
        public double? MarketPrice {get; set;}
        public override double TradeValue()
    {
        double PTU = MarketPrice ?? Price;
        return Quantity * PTU;
    }
    public override string ToString()
    {
        return $"TradeId: {TradeId}, StockSymbol: {StockSymbol}, Quantity: {Quantity}, Price: {Price}, MarketPrice: {MarketPrice}";
    }
    }
public static class TradeAnalytics
{
    public static int TrackTT = 0;
    public static void ShowTrackTrade()
    {
        Console.WriteLine($"Total Trades Tracked: {TrackTT}");
    }
}
public static class TradeExtensions
{
    public static double BrokerageFee(this double amount, double percentage)
    {
        return amount * percentage / 100;
    }

    public static double Tax(this double amount, double percentage)
    {
        return amount * percentage / 100;
    }
}
public static class TradeProcessor
{
    public static void ProcessTrade(Trade trade)
    {
        if (trade is EquityTrade eq)
        {
            Console.WriteLine("Processing Equity Trade");
            Console.WriteLine($"Stock: {eq.StockSymbol}, Value: {eq.TradeValue()}");
        }
        else
        {
            Console.WriteLine("Processing Other Trade Type");
        }
    }
}

