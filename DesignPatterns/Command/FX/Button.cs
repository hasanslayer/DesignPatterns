using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command.FX
{
    public class Button
    {
        private string label;
        private Command command;

        public Button(Command command)
        {
            this.command = command;
        }

        public void Click()
        {
            command.Execute();
        }

        public string GetLabel()
        {
            return label;
        }

        public void SetLabel(string value)
        {
            label = value;
        }
    }
}
