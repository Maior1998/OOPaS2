using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer.abstracts;

namespace Observer.Displays
{
    class ThirdPartyDisplay : abstracts.Object, IDisplayable
    {
        public ThirdPartyDisplay(Subject source) : base(source)
        {
            isfoggy = ((WeatherStation)datasource).Visibility < 500;
        }

        private bool isfoggy;

        public override void Update(string changedProperty)
        {
            WeatherStation weatherstationsource = (WeatherStation)datasource;
            if (changedProperty != nameof(WeatherStation.Visibility)) return;
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
