using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class BlackAndWhiteFilter : Filter
    {
        public void Apply(string fileName)
        {
            Console.WriteLine("Applying B&W Filter");
        }
    }
}
