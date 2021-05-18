namespace Observer.Pull
{
    public class Chart : IObserver
    {
        private readonly DataSource _dataSource;

        public Chart(DataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public void Update()
        {
            System.Console.WriteLine("Chart updated to {0}", _dataSource.Value);
        }
    }
}