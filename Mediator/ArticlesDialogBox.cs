using System;

namespace Mediator
{
    // 2. Concrete Mediator
    public class ArticlesDialogBox : DialogBox
    {
        private Button _button;
        private ListBox _listBox;
        private TextBox _textBox;

        public ArticlesDialogBox()
        {
            _button = new(this);
            _listBox = new(this);
            _textBox = new(this);
        }

        public override void Changed(UIControl control)
        {
            if (control == _listBox)
            {
                ArticleSelected();
            }
            else if (control == _textBox)
            {
                TitleChanged();
            }
        }

        private void TitleChanged()
        {
            var content = _textBox.Content;
            var isEmpty = string.IsNullOrEmpty(content);
            _button.IsEnabled = !isEmpty;
        }

        private void ArticleSelected()
        {
            _textBox.Content = _listBox.Selection;
            _button.IsEnabled = true;
        }

        public void SimulateUserInteraction()
        {
            _listBox.Selection = "Article 1";
            _listBox.Selection = "";
            System.Console.WriteLine("Text Box: {0}", _textBox.Content);
            System.Console.WriteLine("Button: {0}", _button.IsEnabled);
        }
    }
}