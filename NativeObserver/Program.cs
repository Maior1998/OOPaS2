using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NativeObserver.Displays;

namespace NativeObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherStation station = new WeatherStation();
            CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(station);
            TempStatDisplay tempStatDisplay = new TempStatDisplay(station);
            ThirdPartyDisplay thirdPartyDisplay = new ThirdPartyDisplay(station);
            Random rand = new Random();
            for (int i = 0; i < 30; i++)
            {
                station.Temperature = rand.Next(10, 40);
            }
            for (int i = 0; i < 10; i++)
            {
                station.Visibility = rand.Next(100, 900);
            }
            Console.WriteLine();
        }
    }
}
