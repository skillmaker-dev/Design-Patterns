using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Pattern
{
    internal class Brush : Tool
    {
        public void MouseDown()
        {
            Console.WriteLine("Brush Tool");
        }

        public void MouseUp()
        {
            Console.WriteLine("Drawing");
        }
    }
}
