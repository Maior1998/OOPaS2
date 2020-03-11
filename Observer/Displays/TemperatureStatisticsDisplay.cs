using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Observer.abstracts;

namespace Observer.Displays
{
    class TempStatDisplay : abstracts.Observer, IDisplayable
    {
        private readonly Queue<double> tempstats = new Queue<double>();

        public TempStatDisplay(WeatherStation source) : base(source)
        {

        }

        public override void Update(string changedproperty)
        {
            WeatherStation weatherstationsource = (WeatherStation)datasource;
            if (changedproperty != nameof(WeatherStation.Temperature)) return;
            tempstats.Enqueue(weatherstationsource.Temperature);
            while (tempstats.Count > 10)
                tempstats.Dequeue();
            Display();
        }
        //TODO: нет возможности трекать сразу нескольких обработчиков погоды. исправить?

        public void Display()
        {
            Console.WriteLine($"Minimal temperatue: {tempstats.Min()}; Average Temperature: {tempstats.Average()}; Max Temperature: {tempstats.Max()}");
        }

        public override void Dispose()
        {
            tempstats.Clear();
            base.Dispose();
        }


    }
}
