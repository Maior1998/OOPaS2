using Observer.abstracts;

namespace Observer
{
    internal class WeatherStation : Subject
    {
        private double humidity;

        private double oxygenpercentage;

        private double pressure;

        private double rainfall;
        private double temperature;

        private double visibility;

        public double Temperature
        {
            get => temperature;
            set
            {
                temperature = value;
                NotifyObservers(nameof(Temperature));
            }
        }

        public double Humidity
        {
            get => humidity;
            set
            {
                humidity = value;
                NotifyObservers(nameof(Humidity));
            }
        }

        public double Pressure
        {
            get => pressure;
            set
            {
                pressure = value;
                NotifyObservers(nameof(Pressure));
            }
        }

        public double OxygenPercentage
        {
            get => oxygenpercentage;
            set
            {
                oxygenpercentage = value;
                NotifyObservers(nameof(OxygenPercentage));
            }
        }

        public double Visibility
        {
            get => visibility;
            set
            {
                visibility = value;
                NotifyObservers(nameof(Visibility));
            }
        }

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