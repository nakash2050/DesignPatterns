namespace Command.Editor
{
    public class BoldCommand : UndoableCommand
    {
        private string _prevContent;
        private HtmlDocument _document;
        private History _history;

        public BoldCommand(HtmlDocument htmlDocument, History history)
        {
            _document = htmlDocument;
            _history = history;
        }

        public void Execute()
        {
            _prevContent = _document.Content;
            _document.MakeBold();
            _history.Push(this);
        }

        public void UnExecute()
        {
            _document.Content = _prevContent;
        }
    }
}