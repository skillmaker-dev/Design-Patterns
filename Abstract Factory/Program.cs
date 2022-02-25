using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lenovoFactory = new LenovoFactory();

            var ideaPad = lenovoFactory.CreateLaptop("IdeaPad");
            var thinkPad = lenovoFactory.CreateLaptop("ThinkPad");

            Console.WriteLine("Laptop ideapad price : {0}",ideaPad.GetPrice());
            Console.WriteLine("Laptop thinkpad price : {0}",thinkPad.GetPrice());



            var hpFactory = new HpFactory();

            var proBook = hpFactory.CreateLaptop("ProBook");
            var eliteBook = hpFactory.CreateLaptop("EliteBook");

            Console.WriteLine("Laptop proBook price : {0}", proBook.GetPrice());
            Console.WriteLine("Laptop eliteBook price : {0}", eliteBook.GetPrice());
        }
    }
}
