using Command.Fx;

namespace Command.Composite
{
    public class ResizeCommand : ICommand
    {
        public void Execute()
        {
            System.Console.WriteLine("Executing command to resize");
        }
    }
}