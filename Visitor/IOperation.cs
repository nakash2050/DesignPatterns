namespace Visitor
{
    // 3. Visitor
    public interface IOperation
    {
        void Apply(HeadingNode headingNode);
        void Apply(AnchorNode anchorNode);
    }
}