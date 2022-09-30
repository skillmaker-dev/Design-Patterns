using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Let's store the data directly
            StoreCreditCard(new LocalStore());

            //Let's encrypt Data before storing it localy
            StoreCreditCard(new CompressData(new LocalStore()));

            //Let's encrypt data before storing it localy
            StoreCreditCard(new EncryptData(new LocalStore()));

            //Let's encrypt data then compress it then store it localy
            StoreCreditCard(new EncryptData(new CompressData(new LocalStore())));



        }

        public static void StoreCreditCard(IStore store)
        {
            store.Store("Fake data");
        }
    }
}
