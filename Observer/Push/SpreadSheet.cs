namespace Observer.Push
{
    // 3. Concrete Observer
    public class SpreadSheet : IObserver
    {
        public void Update(int value)
        {
            System.Console.WriteLine("Spread sheet value updated to {0}", value);
        }
    }
}