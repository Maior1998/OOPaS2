using System.Collections.Generic;

namespace Observer.abstracts
{
    public abstract class Subject
    {
        private readonly List<Object> observers =new List<Object>();

        public void Register(Object target)
        {
            if(!observers.Contains(target))
                observers.Add(target);
        }

        public void Remove(Object target)
        {
            observers.Remove(target);
        }

        public void NotifyObservers(string changedProperty)
        {
            foreach (Object observer in observers)
                observer.Update(changedProperty);
        }
    }
}
