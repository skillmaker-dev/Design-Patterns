using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Pattern
{
    internal class Canvas : Tool
    {
        public Tool Tool { get; set; }

        public void MouseUp()
        {
            Tool.MouseUp();
        }

        public void MouseDown()
        {
            Tool.MouseDown();
        }
    }
}
