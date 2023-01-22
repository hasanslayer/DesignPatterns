using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command.Editor
{
    public class History
    {
        private List<UndoableCommand> commands = new List<UndoableCommand>();

        public void Push(UndoableCommand command)
        {
            commands.Add(command);
        }

        public UndoableCommand Pop()
        {
            var lastIndex = commands.Count - 1;
            var lastState = commands[lastIndex];
            commands.Remove(lastState);

            return lastState;
        }

        public int Count()
        {
            return commands.Count;
        }
    }
}
