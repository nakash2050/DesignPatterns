namespace Command.Editor
{
    public class UndoCommand : ICommand
    {
        private History _history;

        public UndoCommand(History history)
        {
            _history = history;
        }

        public void Execute()
        {
            if (_history.Size() > 0)
            {
                _history.Pop().UnExecute();
            }
        }
    }
}