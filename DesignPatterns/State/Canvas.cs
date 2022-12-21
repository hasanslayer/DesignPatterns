using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public class Canvas
    {
        private Tool currentTool;

        public void MouseDown()
        {
            currentTool.MouseDown();
        }
        public void MouseUp()
        {
            currentTool.MouseUp(); 
        }

        public Tool GetCurrentTool()
        {
            return currentTool;
        }

        public void SetCurrentTool(Tool value)
        {
            currentTool = value;
        }
    }
}
