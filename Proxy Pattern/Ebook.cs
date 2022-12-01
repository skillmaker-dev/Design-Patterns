namespace Proxy_Pattern
{
    public class Ebook : IEbook
    {
        public string FileName { get; set; }
        public Ebook(string fileName)
        {
            FileName = fileName;
            Load();
        }

        public void Show()
        {
            Console.WriteLine("Showing the ebook : " + FileName);
        }

        public void Load()
        {
            Console.WriteLine("Loading the ebook : " + FileName);
        }
    }
}