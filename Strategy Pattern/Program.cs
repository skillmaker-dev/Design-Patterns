using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ImageStorage.Store("src/images/image",new JpegCompressor(),new BlackAndWhiteFilter());

        }
    }
}
