namespace Proxy_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var library = new Library();
            string[] filenames = { "a","b","c","d" };

            foreach(string filename in filenames)
                library.AddEbook(new EbookProxy(filename));

            library.OpenEbook("a");
        }
    }
}