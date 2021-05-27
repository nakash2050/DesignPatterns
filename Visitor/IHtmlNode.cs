namespace Visitor
{
    // 1. Element
    public interface IHtmlNode
    {
        void Execute(IOperation operation);
    }
}