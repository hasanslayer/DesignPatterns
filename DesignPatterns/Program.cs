
using DesignPatterns.Memento;
using DesignPatterns.State;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var canvas = new Canvas();
            canvas.SetCurrentTool(new BrushTool());
            canvas.MouseDown();
            canvas.MouseUp();
        }
    }
}