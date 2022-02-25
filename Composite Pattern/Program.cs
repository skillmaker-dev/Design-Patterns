using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var folder1 = new Folder("folder1");
            var folder2 = new Folder("folder2");

            var file1 = new File(10, "file1");
            var file2 = new File(10, "file2");
            var file3 = new File(10, "file3");
            var file4 = new File(10, "file4");
            var file5 = new File(10, "file5");

            folder1.AddComponent(file1);
            folder1.AddComponent(file2);

            folder2.AddComponent(file3);
            folder2.AddComponent(file4);
            folder2.AddComponent(file5);

            folder1.AddComponent(folder2);

            folder1.ShowDetails();
        }
    }
}
