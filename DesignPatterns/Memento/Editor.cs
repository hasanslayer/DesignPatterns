using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento
{
    public class Editor
    {
        private string content;

        public EditorState CreateState()
        {
            return new EditorState(content);
        }

        public void Restore(EditorState editorState)
        {
            content = editorState.GetContent();
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
