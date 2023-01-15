
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
            // Transfer Money
            var task = new TransferMoneyTask();
            task.Execute();
           // Generate Report
        }
    }
}