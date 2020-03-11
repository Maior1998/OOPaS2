using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer.abstracts;

namespace Observer.Displays
{
    class ThirdPartyDisplay : abstracts.Observer, IDisplayable
    {
        public ThirdPartyDisplay(Observable source) : base(source)
        {
            isfoggy = ((WeatherStation)datasource).Visibility < 500;
        }

        private bool isfoggy;

        public override void Update(string changedproperty)
        {
            WeatherStation weatherstationsource = (WeatherStation)datasource;
            if (changedproperty != nameof(WeatherStation.Visibility)) return;
            if (!isfoggy && weatherstationsource.Visibility < 500)
                Display();
            isfoggy = weatherstationsource.Visibility < 500;
        }

        public void Display()
        {
            Console.WriteLine("It's getting very foggy!");
        }
    }
}
