using DesignPatterns.Command.Editor;
using History = DesignPatterns.Command.Editor.History;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var history = new History();
            var document = new HtmlDocument();
            document.SetContent("Hello World");

            var boldCommand = new BoldCommand(document, history);
            boldCommand.Execute();
            Console.WriteLine(document.GetContent());


            var undoCommand = new UndoCommand(history);
            undoCommand.Execute();
            Console.WriteLine(document.GetContent());
        }
    }
}