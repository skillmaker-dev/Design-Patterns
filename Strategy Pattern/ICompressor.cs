using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    internal interface ICompressor
    {
        void Compress(string imageUrl);
    }
}
