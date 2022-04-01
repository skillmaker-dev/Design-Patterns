using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    internal static class ImageStorage
    {
        static public void Store(string ImageUrl,ICompressor compressor,IFilter filter)
        {
            compressor.Compress(ImageUrl);
            filter.ApplyFilter(ImageUrl);
        }
    }
}
