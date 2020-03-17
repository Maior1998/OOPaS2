using System;

namespace Observer.abstracts
{
    public abstract class Object : IDisposable

    {
        protected Subject datasource;

        protected Object(Subject source)
        {
            datasource = source;
            datasource.Register(this);
        }

        public virtual void Dispose()
        {
            datasource.Remove(this);
        }

        public abstract void Update(string changedproperty);
    }
}