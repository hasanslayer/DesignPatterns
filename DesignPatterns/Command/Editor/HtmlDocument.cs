using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command.Editor
{
    public class HtmlDocument
    {
        private string content;

        public void MakeBold()
        {
            content = $"<b>{content}</b>";
        }

        public string GetContent()
        {
            return content;
        }

        public void SetContent(string value)
        {
            content = value;
        }
    }
}
