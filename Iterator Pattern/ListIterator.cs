namespace Iterator_Pattern
{
    
        public class ListIterator : IIterator
        {
            private readonly BrowserHistory browserHistory;
            private int _index;

            public ListIterator(BrowserHistory browserHistory)
            {
                this.browserHistory = browserHistory;
            }
            public string Current()
            {
                return browserHistory.History[_index];
            }

            public bool HasNext()
            {
                return _index < browserHistory.History.Count;
            }

            public void Next()
            {
                _index++;
            }
        }

    
}
