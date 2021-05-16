namespace Strategy
{
    // 3. Strategy Implementation
    public class HighContrastFilter : IFilter
    {
        public void Apply()
        {
            System.Console.WriteLine("Applying High Contrast filter");
        }
    }
}