using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer.abstracts;

namespace Observer
{
    class WeatherStation : Observable
    {
        private double temperature;
        public double Temperature
        {
            get => temperature;
            set
            {
                temperature = value;
                NotifyObservers(nameof(Temperature));
            }
        }
        
        private double humidity;
        public double Humidity
        {
            get => humidity;
            set
            {
                humidity = value;
                NotifyObservers(nameof(Humidity));
            }
        }

        private double pressure;
        public double Pressure
        {
            get => pressure;
            set
            {
                pressure = value;
                NotifyObservers(nameof(Pressure));
            }
        }

        private double oxygenpercentage;
        public double OxygenPercentage
        {
            get => oxygenpercentage;
            set
            {
                oxygenpercentage = value;
                NotifyObservers(nameof(OxygenPercentage));
            }
        }

        private double visibility;
        public double Visibility
        {
            get => visibility;
            set
            {
                visibility = value;
                NotifyObservers(nameof(Visibility));
            }
        }

        private double rainfall;
        public double Rainfall
        {
            get => rainfall;
            set
            {
                rainfall = value;
                NotifyObservers(nameof(Rainfall));
            }
        }
    }
}
