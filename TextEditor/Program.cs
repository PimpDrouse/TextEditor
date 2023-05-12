using System;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace TextEditor
{
    public class TextEditor
    {
        public static void Main(string[] args)
        {
            Editor editor = Editor.GetInstance();
            editor.Start();
        }
    }
}