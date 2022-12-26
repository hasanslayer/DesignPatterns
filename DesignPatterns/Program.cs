
using DesignPatterns.Iterator;
using DesignPatterns.Memento;
using DesignPatterns.State;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var history = new BrowseHistory();

            history.Push("a");
            history.Push("b");
            history.Push("c");

            Iterator.Iterator iterator = history.CreateIterator();

            while (iterator.HasNext())
            {
                var url = iterator.Current();
                Console.WriteLine(url);
                iterator.Next();
            }


        }
    }
}