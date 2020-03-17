using System;
using Observer.abstracts;
using Object = Observer.abstracts.Object;

namespace Observer.Displays
{
    internal class ThirdPartyDisplay : Object, IDisplayable
    {
        private bool isfoggy;

        public ThirdPartyDisplay(Subject source) : base(source)
        {
            isfoggy = ((WeatherStation) datasource).Visibility < 500;
        }

        public void Display()
        {
            Console.WriteLine("It's getting very foggy!");
        }

        public override void Update(string changedProperty)
        {
            WeatherStation weatherstationsource = (WeatherStation) datasource;
            if (changedProperty != nameof(WeatherStation.Visibility)) return;
            if (!isfoggy && weatherstationsource.Visibility < 500)
                Display();
            isfoggy = weatherstationsource.Visibility < 500;
        }
    }
}