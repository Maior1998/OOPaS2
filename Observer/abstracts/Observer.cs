using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.abstracts
{
    public abstract class Observer : IDisposable

    {
        protected Observable datasource;

        protected Observer(Observable source)
        {
            datasource = source;
            datasource.Register(this);
        }

        public abstract void Update(string changedproperty);

        public virtual void Dispose()
        {
            datasource.Remove(this);
        }
    }
}
