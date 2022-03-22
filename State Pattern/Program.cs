using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var canvas = new Canvas();
            canvas.Tool = new Brush();

            canvas.MouseUp();
            canvas.MouseDown();

            canvas.Tool = new Fill();

            canvas.MouseDown();
            canvas.MouseUp();
        }
    }
}
