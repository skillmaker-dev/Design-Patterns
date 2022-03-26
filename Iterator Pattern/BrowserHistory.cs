using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern
{
    public class BrowserHistory<T>
    {
        public List<T> History { get; private set; } = new List<T>();

        public void Push(T obj)
        {
            History.Add(obj);
        }

        public T Pop()
        {
            var removedobj =  History[History.Count - 1];
            History.Remove(removedobj);

            return removedobj;
        }

        public IIterator<T> CreateListIterator()
        {
            return new ListIterator<T>(this);
        }

    }
}
