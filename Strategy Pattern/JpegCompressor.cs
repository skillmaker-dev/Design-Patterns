using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    internal class JpegCompressor : ICompressor
    {
        public void Compress(string imageUrl)
        {
            Console.WriteLine($"Compressing {imageUrl} using JPEG");
        }
    }
}
