using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command.Editor
{
    public class UndoCommand : Command
    {
        private History history;

        public UndoCommand(History history)
        {
            this.history = history;
        }

        public void Execute()
        {
            if (history.Count() > 0)
            {
                history.Pop().UnExecute();
            }
            
        }
    }
}
