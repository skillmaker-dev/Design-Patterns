using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Pattern
{
    internal class Fill : Tool
    {
        public void MouseDown()
        {
            Console.WriteLine("Filling tool");
        }

        public void MouseUp()
        {
            Console.WriteLine("Object Filled");
        }
    }
}
