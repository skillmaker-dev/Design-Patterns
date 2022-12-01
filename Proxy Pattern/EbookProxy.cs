namespace Proxy_Pattern
{
    public class EbookProxy : IEbook
    {
        public string FileName { get; set; }
        private Ebook _ebook;
        public EbookProxy(string filename)
        {
            FileName = filename;
        }

        public void Show()
        {
            if (_ebook is null)
                _ebook = new Ebook(FileName);

            _ebook.Show();
        }
    }
}