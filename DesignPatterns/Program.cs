
using DesignPatterns.Iterator;
using DesignPatterns.Memento;
using DesignPatterns.State;
using DesignPatterns.Strategy;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ImageStorage imageStorage = new ImageStorage();
            imageStorage.Store("fileName",new PngCompressor(), new BlackAndWhiteFilter());
            imageStorage.Store("fileName",new JpegCompressor(), new HighContrastFilter());
        }
    }
}