using System;
using Observer.abstracts;
using Object = Observer.abstracts.Object;

namespace Observer.Displays
{
    public class CurrentConditionsDisplay : Object, IDisplayable
    {
        public CurrentConditionsDisplay(Subject source) : base(source)
        {
        }

        public void Display()
        {
            WeatherStation weatherstationsource = (WeatherStation) datasource;
            Console.WriteLine($"temperature = {weatherstationsource.Temperature}\n" +
                              $"humidity={weatherstationsource.Humidity}\n" +
                              $"pressure={weatherstationsource.Pressure}\n" +
                              $"oxygenpercentage={weatherstationsource.OxygenPercentage}\n" +
                              $"visibility={weatherstationsource.Visibility}\n" +
                              $"rainfall={weatherstationsource.Rainfall}");
        }

        public override void Update(string changedProperty)
        {
            Display();
        }
    }
}