using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer.abstracts;

namespace Observer.Displays
{
    public class CurrentConditionsDisplay: abstracts.Object, IDisplayable
    {
        public CurrentConditionsDisplay(Subject source) : base(source)
        {
        }

        public override void Update(string changedProperty)
        {
            Display();
        }

        public void Display()
        {
            WeatherStation weatherstationsource = (WeatherStation)datasource;
            Console.WriteLine($"temperature = {weatherstationsource.Temperature}\n" +
                              $"humidity={weatherstationsource.Humidity}\n" +
                              $"pressure={weatherstationsource.Pressure}\n" +
                              $"oxygenpercentage={weatherstationsource.OxygenPercentage}\n" +
                              $"visibility={weatherstationsource.Visibility}\n" +
                              $"rainfall={weatherstationsource.Rainfall}");
        }
    }
}
