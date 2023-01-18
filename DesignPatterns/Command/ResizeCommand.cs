using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command
{
    public class ResizeCommand : FX.Command
    {
        public void Execute()
        {
            Console.WriteLine("Resize");
        }
    }
}
