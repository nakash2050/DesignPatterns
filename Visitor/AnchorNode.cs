namespace Visitor
{
    // 2. Concrete Element
    public class AnchorNode : IHtmlNode
    {
        public void Execute(IOperation operation)
        {
            operation.Apply(this);
        }
    }
}