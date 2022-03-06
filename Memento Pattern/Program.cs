using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var editor = new Editor();
            var history = new History();

            editor.Content = "A";
            history.Push(editor.CreateState());

            editor.Content = "B";
            history.Push(editor.CreateState());

            editor.Content = "C";
            editor.Restore(history.Pop());

            Console.WriteLine(editor.Content);


        }
    }
}
