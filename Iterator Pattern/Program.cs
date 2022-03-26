using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var history = new BrowserHistory();

            history.Push("Link1");
            history.Push("Link2");
            history.Push("Link3");
            history.Push("Link4");


            var listIterator = history.CreateListIterator();


            while(listIterator.HasNext())
            {
                Console.WriteLine(listIterator.Current());
                listIterator.Next();
            }
        }
    }

}
