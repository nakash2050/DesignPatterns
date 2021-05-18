namespace Command.Editor
{
    public interface UndoableCommand : ICommand
    {
        void UnExecute();
    }
}