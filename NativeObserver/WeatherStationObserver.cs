using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NativeObserver
{
    public abstract class WeatherStationObserver : IObserver<WeatherInfo>
    {
        protected IDisposable unsubscriber;

        protected WeatherStationObserver(WeatherStation source)
        {
            unsubscriber = source.Subscribe(this);
        }
        public abstract void OnNext(WeatherInfo value);

        public void OnError(Exception error)
        {
            Console.WriteLine($"Error occurred in observable!: {error.Message}");
        }
        
        public void OnCompleted()
        {
            Console.WriteLine("Observable reported end.");
        }
    }
}
