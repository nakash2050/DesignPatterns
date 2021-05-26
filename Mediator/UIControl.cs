namespace Mediator
{
    // 3. Collegue
    public class UIControl
    {
        protected DialogBox _owner;

        public UIControl(DialogBox owner)
        {
            _owner = owner;
        }
    }
}