namespace Iterator_Pattern
{
    
        public class ListIterator<T> : IIterator<T>
        {
            private readonly BrowserHistory<T> browserHistory;
            private int _index;

            public ListIterator(BrowserHistory<T> browserHistory)
            {
                this.browserHistory = browserHistory;
            }
            public T Current()
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
