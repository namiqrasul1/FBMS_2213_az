using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Storage
    {
        private List<TextEditorMemento> Mementos { get; set; } = new();
        public TextEditor Text { get; set; } = new();

        public void Append(string text) => Text.Append(text);

        public void Show() => Text.Show();

        public void Save() => Mementos.Add(Text.Save());

        public void Undo()
        {
            if (Mementos.Count > 0)
            {
                var lastSave = Mementos.Last();
                Mementos.Remove(lastSave);
                Text.Text = lastSave.Text;
            }
            else
                throw new Exception("save not found");
        }
    }
}
