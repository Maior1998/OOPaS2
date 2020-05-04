using System;

namespace NativeObserver.Displays
{
    public class ThirdPartyDisplay : WeatherStationObserver
    {
        private bool isfoggy;
        private IDisposable unsubscriber;
        public ThirdPartyDisplay(WeatherStation source) : base(source)
        {
            isfoggy = source.Visibility < 500;
        }
        private void Display()
        {
            Console.WriteLine("It's getting very foggy!");
        }

        public override void OnNext(WeatherInfo value)
        {
            if(!isfoggy && value.Visibility < 500)
                Display();
            isfoggy = value.Visibility < 500;
        }
    }
}