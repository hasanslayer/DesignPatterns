using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Iterator
{
    public class BrowseHistory
    {
        private List<string> urls = new List<string>();

        public void Push(string url)
        {
            urls.Add(url);
        }

        public string Pop()
        {
            var lastIndex = urls.Count - 1;
            var lastUrl = urls[lastIndex];
            urls.Remove(lastUrl);

            return lastUrl;

        }

        public Iterator CreateIterator()
        {
            return new ListIterator(this);
        }

        public class ListIterator : Iterator
        {
            private BrowseHistory history;
            private int index;

            public ListIterator(BrowseHistory history)
            {
                this.history = history;
            }

            public string Current()
            {
                return history.urls[index];
            }

            public bool HasNext()
            {
                return index < history.urls.Count;
            }

            public void Next()
            {
                index++;
            }
        }
    }
}
