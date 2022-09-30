using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    // The decorator (the extending functionality we are adding to the Concrete Component).
    internal class EncryptData : IStore
    {
        private readonly IStore _store;

        public EncryptData(IStore store)
        {
            _store = store;
        }
        public void Store(string data)
        {
            // For the sake of simplicity we are just going to do a fake encryption.
            var encryptedData = "@~8*627RRTe2t41";

            _store.Store(encryptedData);
        }
    }
}
