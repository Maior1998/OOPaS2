using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public abstract void Update(string changedproperty);

        public virtual void Dispose()
        {
            datasource.Remove(this);
        }
    }
}
