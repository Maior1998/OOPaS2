using System.Collections.Generic;

namespace Observer.abstracts
{
    public abstract class Observable
    {
        private readonly List<Observer> observers =new List<Observer>();

        public void Register(Observer target)
        {
            if(!observers.Contains(target))
                observers.Add(target);
        }

        public void Remove(Observer target)
        {
            observers.Remove(target);
        }

        public void NotifyObservers(string changedproperty)
        {
            foreach (Observer observer in observers)
                observer.Update(changedproperty);
        }
    }
}
