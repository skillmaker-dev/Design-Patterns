using System;

namespace Strategy_Pattern
{
    internal class PngCompressor : ICompressor
    {
        public void Compress(string imageUrl)
        {
            Console.WriteLine($"Compressing {imageUrl} using PNG");
        }
    }
}
