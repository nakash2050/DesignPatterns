namespace Command.Fx
{
    // 1. Invoker
    public class Button
    {
        private string _label;
        private ICommand _command;

        public Button(ICommand command)
        {
            _command = command;
        }

        public string Label { get => _label; set => _label = value; }

        public void Click()
        {
            _command.Execute();
        }
    }
}