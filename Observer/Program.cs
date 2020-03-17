using Observer.Displays;

namespace Observer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            WeatherStation station = new WeatherStation
            {
                Temperature = 30.0,
                Humidity = 50,
                OxygenPercentage = 70,
                Pressure = 30,
                Rainfall = 50,
                Visibility = 40
            };

            TempStatDisplay tempstatdisplay = new TempStatDisplay(station);
            CurrentConditionsDisplay curconddisplay = new CurrentConditionsDisplay(station);
            ThirdPartyDisplay thirdpartydisplay = new ThirdPartyDisplay(station);
            station.Temperature = 100;
            station.Humidity = 50;
            station.OxygenPercentage = 90;
            station.Pressure = 120;
            station.Rainfall = 70;
            station.Visibility = 90;
            station.Temperature = 130;
            station.Temperature = 20;
            station.Temperature = 70;
            station.Temperature = 22;
            station.Visibility = 900;
            station.Visibility = 400;
        }
    }
}