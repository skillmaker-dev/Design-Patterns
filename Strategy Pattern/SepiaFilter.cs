using System;

namespace Strategy_Pattern
{
    internal class SepiaFilter : IFilter
    {
        public void ApplyFilter(string imageUrl)
        {
            Console.WriteLine($"Applying Sepia filter to {imageUrl}");
        }
    }
}
