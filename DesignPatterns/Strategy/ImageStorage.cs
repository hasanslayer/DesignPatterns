using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class ImageStorage
    {
        public void Store(string fileName, Compressor compressor, Filter filter)
        {
            compressor.Compress(fileName);

            filter.Apply(fileName);
        }
    }
}
