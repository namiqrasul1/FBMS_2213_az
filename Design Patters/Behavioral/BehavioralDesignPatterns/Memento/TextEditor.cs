using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class TextEditor
    {
        public TextEditor(string text)
        {
            Text = text;
        }

        public TextEditor()
        {
            Text = "";
        }

        public string Text { get; set; }

        public void Append(string text) => Text += text;

        public TextEditorMemento Save() => new TextEditorMemento(Text);

        public void Undo(TextEditorMemento memento) => Text = memento.Text;

        public void Show() => Console.WriteLine(Text);
    }
}
