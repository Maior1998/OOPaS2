using System.Collections.Generic;

namespace Observer.abstracts
{
    public abstract class Subject
    {
        private readonly List<Observer> _observers =new List<Observer>();

        public void Register(Observer Target)
        {
            if(!_observers.Contains(Target))
                _observers.Add(Target);
        }

        public void Remove(Observer Target)
        {
            _observers.Remove(Target);
        }

        public void NotifyObservers()
        {
            foreach (Observer Observer in _observers)
                Observer.Update();
        }
    }
}
