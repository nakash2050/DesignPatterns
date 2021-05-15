namespace State
{
    // 4. Concrete State 2
    public class BrushTool : ITool
    {
        public void MouseDown()
        {
            System.Console.WriteLine("Brush Tool: Show icon");
        }

        public void MouseUp()
        {
            System.Console.WriteLine("Brush Tool: Show brush");
        }
    }
}