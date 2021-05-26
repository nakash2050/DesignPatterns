namespace Mediator
{
    // 4. Concrete Collegue
    public class TextBox : UIControl
    {
        private string _content;

        public string Content { get => _content; set {_content = value; _owner.Changed(this); } }
        
        public TextBox(DialogBox owner) : base(owner)
        {
        }
    }
}