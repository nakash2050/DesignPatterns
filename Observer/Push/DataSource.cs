namespace Observer.Push
{
    public class DataSource : Subject
    {
        private int _value;
        
        public int Value 
        { 
            get => _value; 
            set 
            { 
                _value = value; 
                NotifyObservers(_value); 
            }
        }
    }
}