namespace Command.Editor
{
    public class HtmlDocument
    {
        private string _content;

        public string Content { get => _content; set => _content = value; }

        public void MakeBold()
        {
            _content = $"<b>{_content}</b>";
        }
    }
}