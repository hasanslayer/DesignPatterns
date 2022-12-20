using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento
{
    public class History
    {
        private List<EditorState> editorStates = new List<EditorState>();

        public void Push(EditorState editorState)
        {
            editorStates.Add(editorState);
        }

        public EditorState Pop()
        {
            var lastIndex = editorStates.Count - 1;
            var lastState = editorStates[lastIndex];
            editorStates.Remove(lastState);

            return lastState;
        }
    }
}
