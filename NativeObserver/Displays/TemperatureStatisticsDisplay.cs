using System;
using System.Collections.Generic;
using System.Linq;

namespace NativeObserver.Displays
{
    internal class TempStatDisplay : WeatherStationObserver
    {
        private readonly Queue<double> tempstats = new Queue<double>();
        private IDisposable unsubscriber;
        public TempStatDisplay(WeatherStation source) :base(source)
        {
        }
        
        public void Display()
        {
            Console.WriteLine(
                $"Minimal temperatue: {tempstats.Min():F1}; Average Temperature: {tempstats.Average():F1}; Max Temperature: {tempstats.Max():F1}");
        }

        public override void OnNext(WeatherInfo value)
        {
            tempstats.Enqueue(value.Temperature);
            while (tempstats.Count > 10)
                tempstats.Dequeue();
            Display();
        }
    }
}