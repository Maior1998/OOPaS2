
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace NativeObserver
{
    public class WeatherInfo
    {
        public WeatherInfo(
            double humidity,
            double oxygenPercentage, 
            double pressure,
            double rainfall,
            double temperature,
            double visibility)
        {
            Humidity = humidity;
            OxygenPercentage = oxygenPercentage;
            Pressure = pressure;
            Rainfall = rainfall;
            Temperature = temperature;
            Visibility = visibility;
        }
        public double Humidity { get; }
        public double OxygenPercentage { get; }
        public double Pressure { get; }
        public double Rainfall { get; }
        public double Temperature { get; }
        public double Visibility { get; }
    }
    public class WeatherStation : IObservable<WeatherInfo>
    {
        private double humidity;
        private double oxygenpercentage;
        private double pressure;
        private double rainfall;
        private double temperature;
        private double visibility;

        private readonly HashSet<IObserver<WeatherInfo>> subscribers = new HashSet<IObserver<WeatherInfo>>();

        public double Temperature
        {
            get => temperature;
            set
            {
                temperature = value;
                OnUpdate();
            }
        }
        public double Humidity
        {
            get => humidity;
            set
            {
                humidity = value;
                OnUpdate();
            }
        }
        public double Pressure
        {
            get => pressure;
            set
            {
                pressure = value;
                OnUpdate();
            }
        }
        public double OxygenPercentage
        {
            get => oxygenpercentage;
            set
            {
                oxygenpercentage = value;
                OnUpdate();
            }
        }
        public double Visibility
        {
            get => visibility;
            set
            {
                visibility = value;
                OnUpdate();
            }
        }
        public double Rainfall
        {
            get => rainfall;
            set
            {
                rainfall = value;
                OnUpdate();
            }
        }

        private void OnUpdate()
        {
            WeatherInfo changed = new WeatherInfo(
                Humidity,
                OxygenPercentage,
                Pressure,
                Rainfall,
                Temperature,
                Visibility
                    );
            foreach (IObserver<WeatherInfo> subscriber in subscribers)
            {
                subscriber.OnNext(changed);
            }
        }


        public IDisposable Subscribe(IObserver<WeatherInfo> observer)
        {
            if (!subscribers.Contains(observer))
                subscribers.Add(observer);
            return new Unsubscriber(subscribers, observer);
        }
    }

    public class Unsubscriber : IDisposable
    {
        private readonly HashSet<IObserver<WeatherInfo>> subscribers;
        private readonly IObserver<WeatherInfo> currentObserver;

        public Unsubscriber(HashSet<IObserver<WeatherInfo>> subscribers, IObserver<WeatherInfo>
            currentObserver)
        {
            this.subscribers = subscribers;
            this.currentObserver = currentObserver;
        }
        public void Dispose()
        {
            if (subscribers.Contains(currentObserver))
                subscribers.Remove(currentObserver);
        }
    }
}