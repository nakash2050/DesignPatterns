namespace Strategy
{
    // 3. Strategy Implementation
    public class BlackAndWhiteFilter : IFilter
    {
        public void Apply()
        {
            System.Console.WriteLine("Applying Black and White filter");
        }
    }
}