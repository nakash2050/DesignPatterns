using System.Collections.Generic;

namespace Memento
{
    // 3. Caretaker
    public class History
    {
        private readonly List<EditorState> _editorState = new();

        public void Push(EditorState state)
        {
            _editorState.Add(state);
        }

        public EditorState Pop()
        {
            if (_editorState.Count > 0)
            {
                var index = _editorState.Count - 1;
                var lastState = _editorState[index];
                _editorState.Remove(lastState);
                return lastState;
            }

            return null;
        }
    }
}