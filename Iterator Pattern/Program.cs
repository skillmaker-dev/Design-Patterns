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

            //iterating over a list of strings 

            var stringHistory = new BrowserHistory<string>();

            stringHistory.Push("Link1");
            stringHistory.Push("Link2");
            stringHistory.Push("Link3");
            stringHistory.Push("Link4");


            var stringListIterator = stringHistory.CreateListIterator();


            while(stringListIterator.HasNext())
            {
                Console.WriteLine(stringListIterator.Current());
                stringListIterator.Next();
            }




            //iterating over a list of objects

            var objHistory = new BrowserHistory<object>();

            objHistory.Push(new Object());
            objHistory.Push(new Object());
            objHistory.Push(new Object());
            objHistory.Push(new Object());


            var objectListIterator = objHistory.CreateListIterator();


            while (objectListIterator.HasNext())
            {
                Console.WriteLine(objectListIterator.Current());
                objectListIterator.Next();
            }
        }
    }

}
