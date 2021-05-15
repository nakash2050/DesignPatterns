namespace Memento
{
    // 2. Memento
    public class EditorState
    {
        private readonly string _content;

        public EditorState(string content)
        {
            _content = content;
        }

        public string Content => _content;
    }
}