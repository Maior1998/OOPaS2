using System;
using System.Collections.Generic;
using System.Linq;
using Observer.abstracts;
using Object = Observer.abstracts.Object;

namespace Observer.Displays
{
    internal class TempStatDisplay : Object, IDisplayable
    {
        private readonly Queue<double> tempstats = new Queue<double>();

        public TempStatDisplay(WeatherStation source) : base(source)
        {
        }
        //TODO: нет возможности трекать сразу нескольких обработчиков погоды. исправить?

        public void Display()
        {
            Console.WriteLine(
                $"Minimal temperatue: {tempstats.Min()}; Average Temperature: {tempstats.Average()}; Max Temperature: {tempstats.Max()}");
        }

        public override void Update(string changedProperty)
        {
            WeatherStation weatherstationsource = (WeatherStation) datasource;
            if (changedProperty != nameof(WeatherStation.Temperature)) return;
            tempstats.Enqueue(weatherstationsource.Temperature);
            while (tempstats.Count > 10)
                tempstats.Dequeue();
            Display();
        }

        public override void Dispose()
        {
            tempstats.Clear();
            base.Dispose();
        }
    }
}