namespace State
{
    // 3. ConcreteState1
    public class SelectionTool : ITool
    {
        public void MouseDown()
        {
            System.Console.WriteLine("Selection Tool: Show icon");
        }

        public void MouseUp()
        {
            System.Console.WriteLine("Selection Tool: Draw Rectangle");
        }
    }
}