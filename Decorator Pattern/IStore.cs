using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    //The Component we want to implement which is the interface IStore 
    internal interface IStore
    {
        void Store(string data);
    }
}
