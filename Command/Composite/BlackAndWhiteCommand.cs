using Command.Fx;

namespace Command.Composite
{
    public class BlackAndWhiteCommand : ICommand
    {
        public void Execute()
        {
            System.Console.WriteLine("Executing Black and White command");
        }
    }
}