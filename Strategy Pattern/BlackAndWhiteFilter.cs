using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    internal class BlackAndWhiteFilter : IFilter
    {
        public void ApplyFilter(string imageUrl)
        {
            Console.WriteLine($"Applying B&W filter to {imageUrl}");
        }
    }
}
