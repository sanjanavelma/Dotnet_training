using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        PriceSnapshot ps = new PriceSnapshot
        {
            StockSymbol = "MSFT",
            Price = 250.75
        };
        Console.WriteLine($"StockSymbol: {ps.StockSymbol}, Price: {ps.Price}");        
        TradeRepository<EquityTrade> TRepo = new TradeRepository<EquityTrade>();
        var T1= new EquityTrade()
        {
            TradeId = 1,
            StockSymbol = "TCS",
            Quantity = 100,
            Price = 3000,
            MarketPrice = 3050
        };
        var T2= new EquityTrade()
        {
            TradeId = 2,
            StockSymbol = "INFY",
            Quantity = 200,
            Price = 1500,
            MarketPrice = null
        };
        TRepo.AddTrade(T1);
        TRepo.AddTrade(T2);
        TRepo.DisplayTrade();
        Console.WriteLine($"Total Trades: {TradeRepository<EquityTrade>.tradeCount}");
        TradeAnalytics.ShowTrackTrade();
        double value = T1.TradeValue();
        double brokerage = value.BrokerageFee(0.5);
        double gst = brokerage.Tax(18);
        Console.WriteLine(brokerage);
        Console.WriteLine(gst);
        TradeProcessor.ProcessTrade(T1);
        int totalTrades = TradeAnalytics.TrackTT;
        object boxedCount = totalTrades;
        int unboxedCount = (int)boxedCount;
        Console.WriteLine("Boxed Value: " + boxedCount);
        Console.WriteLine("Unboxed Value: " + unboxedCount);
    }
}