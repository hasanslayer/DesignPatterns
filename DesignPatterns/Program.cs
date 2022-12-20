
using DesignPatterns.Memento;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var editor = new Editor();
            var history = new History();

            editor.SetContent("a");
            history.Push(editor.CreateState());

            editor.SetContent("b");
            history.Push(editor.CreateState());

            editor.SetContent("c");
            editor.Restore(history.Pop()); // remove c
            editor.Restore(history.Pop()); // remove b

            Console.WriteLine(editor.GetContent());
        }
    }
}