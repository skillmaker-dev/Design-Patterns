using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var singleton1 = Singleton.GetInstance();
            var singleton2 = Singleton.GetInstance();

            singleton1.Number = 5;

            Console.WriteLine(singleton1.Number);
            Console.WriteLine(singleton2.Number);
        }
    }
}
