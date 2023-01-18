
using DesignPatterns.Command;
using DesignPatterns.Command.FX;
using DesignPatterns.Iterator;
using DesignPatterns.Memento;
using DesignPatterns.State;
using DesignPatterns.Strategy;
using DesignPatterns.Template;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var composite = new CompositeCommand();
            composite.Add(new ResizeCommand());
            composite.Add(new BlackAndWhiteCommand());
            composite.Execute();
        }
    }
}