using System;

namespace NativeObserver.Displays
{
    public class CurrentConditionsDisplay : WeatherStationObserver
    {
        public CurrentConditionsDisplay(WeatherStation station) :base(station)
        {
        }

        public void Display(WeatherInfo value)
        {
            Console.WriteLine($"temperature = {value.Temperature}\n" +
                              $"humidity={value.Humidity}\n" +
                              $"pressure={value.Pressure}\n" +
                              $"oxygenpercentage={value.OxygenPercentage}\n" +
                              $"visibility={value.Visibility}\n" +
                              $"rainfall={value.Rainfall}");
        }

        public override void OnNext(WeatherInfo value)
        {
            Display(value);
        }
    }
}