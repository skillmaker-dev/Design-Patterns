using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    // Concrete Component where we are implementing the abstract Component "IStore"
    internal class LocalStore : IStore
    {
        public void Store(string data)
        {
            Console.WriteLine("Storing to local: " + data);
        }
    }
}
