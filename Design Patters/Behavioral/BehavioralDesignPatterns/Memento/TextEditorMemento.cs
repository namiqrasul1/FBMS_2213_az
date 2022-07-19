namespace Memento
{
    public class TextEditorMemento
    {
        public string Text { get; set; }

        public TextEditorMemento(string text)
        {
            Text = text;
        }

        public TextEditorMemento()
        {
            Text = "";
        }
    }
}