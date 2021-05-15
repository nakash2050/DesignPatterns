using System.Collections.Generic;

namespace Iterator
{
    public class BrowserHistory
    {
        private readonly List<string> _urls = new();

        public void Push(string url)
        {
            _urls.Add(url);
        }

        public void Pop()
        {
            if (_urls.Count > 0)
            {
                var index = _urls.Count - 1;
                var url = _urls[index];
                _urls.Remove(url);
            }
        }

        public IIterator<string> CreateIterator()
        {
            return new ListIterator(this);
        }

        public class ListIterator : IIterator<string>
        {
            private readonly BrowserHistory _browserHistory;
            private int _index;

            public ListIterator(BrowserHistory browserHistory)
            {
                _browserHistory = browserHistory;
            }

            public string Current()
            {
                return _browserHistory._urls[_index];
            }

            public bool HasNext()
            {
                return _index < _browserHistory._urls.Count;
            }

            public void Next()
            {
                _index++;
            }
        }
    }
}