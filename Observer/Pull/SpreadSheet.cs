using Observer.Push;

namespace Observer.Pull
{
    public class SpreadSheet : IObserver
    {
        private readonly DataSource _dataSource;

        public SpreadSheet(DataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public void Update()
        {
            System.Console.WriteLine("Spreadsheet update to {0}", _dataSource.Value);
        }
    }
}