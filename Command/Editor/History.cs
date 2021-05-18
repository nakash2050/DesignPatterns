using System.Collections.Generic;

namespace Command.Editor
{
    public class History
    {
        private Stack<UndoableCommand> _commands = new();

        public void Push(UndoableCommand command)
        {
            _commands.Push(command);
        }

        public UndoableCommand Pop()
        {
            return _commands.Pop();
        }

        public int Size() {
            return _commands.Count;
        }
    }
}