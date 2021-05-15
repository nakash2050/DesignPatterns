namespace State
{
    // 1. Originator
    public class Canvas
    {
        private readonly ITool _tool;

        public Canvas(ITool tool)
        {
            _tool = tool;
        }

        public void MouseUp()
        {
            _tool.MouseUp();
        }

        public void MouseDown()
        {
            _tool.MouseDown();
        }
    }
}