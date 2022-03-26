using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern
{
    public class BrowserHistory
    {
        public List<string> History { get; private set; } = new List<string>();

        public void Push(string url)
        {
            History.Add(url);
        }

        public string Pop()
        {
            var removedUrl =  History[History.Count - 1];
            History.Remove(removedUrl);

            return removedUrl;
        }

        public IIterator CreateListIterator()
        {
            return new ListIterator(this);
        }

    }
}
