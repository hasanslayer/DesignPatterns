using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command.Editor
{
    public class BoldCommand : UndoableCommand
    {
        private string prevContent;
        private HtmlDocument document;
        private History history;

        public BoldCommand(HtmlDocument document, History history)
        {
            this.document = document;
            this.history = history;
        }

        public void Execute()
        {
            prevContent = document.GetContent();
            document.MakeBold();
            history.Push(this);
        }

        public void UnExecute()
        {
            document.SetContent(prevContent);
        }
    }
}
