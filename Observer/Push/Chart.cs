namespace Observer.Push
{
    // 3. Concrete Observer
    public class Chart : IObserver
    {
        public void Update(int value)
        {
            System.Console.WriteLine("Chart value updated to {0}", value);
        }
    }
}