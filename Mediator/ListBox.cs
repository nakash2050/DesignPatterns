namespace Mediator
{
    // 4. Concrete Collegue
    public class ListBox : UIControl
    {
        private string _selection;

        public string Selection { get => _selection; set { _selection = value; _owner.Changed(this); } }

        public ListBox(DialogBox owner) : base(owner)
        {
        }

        // Omitting List of Items
    }
}