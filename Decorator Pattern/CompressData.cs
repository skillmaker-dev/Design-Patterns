using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    // The decorator (the extending functionality we are adding to the Concrete Component).
    internal class CompressData : IStore
    {
        private readonly IStore _store;

        public CompressData(IStore store)
        {
            _store = store;
        }
        public void Store(string data)
        {
            // For the sake of simplicity we are going to do a fake compression
            var compressedData = data.Substring(0, 3);

            _store.Store(compressedData);
        }
    }
}
