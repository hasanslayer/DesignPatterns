using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Iterator
{
    public class BrowseHistory
    {
        private string[] urls = new string[10];
        private int count;

        public void Push(string url)
        {
            urls[count] = url;
            count++;
        }

        public string Pop()
        {
            count--;

            return urls[count];

        }

        public Iterator CreateIterator()
        {
            return new ArrayIterator(this);
        }

        public class ArrayIterator : Iterator
        {
            private BrowseHistory history;
            private int index;

            public ArrayIterator(BrowseHistory history)
            {
                this.history = history;
            }

            public string Current()
            {
                return history.urls[index];
            }

            public bool HasNext()
            {
                return index < history.count;
            }

            public void Next()
            {
                index++;
            }
        }
    }
}
