namespace Proxy_Pattern
{
    public class Library
    {
        public Dictionary<string, IEbook> Ebooks { get; set; } = new Dictionary<string, IEbook>();

        public void AddEbook(IEbook ebook)
        {
            Ebooks.Add(ebook.FileName, ebook);
        }

        public void OpenEbook(string filename)
        {
            Ebooks.GetValueOrDefault(filename)!.Show();
        }
    }
}