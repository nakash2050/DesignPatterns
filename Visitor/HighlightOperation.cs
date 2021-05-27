namespace Visitor
{
    public class HighlightOperation : IOperation
    {
        public void Apply(HeadingNode headingNode)
        {
            System.Console.WriteLine("Highlight Heading");
        }

        public void Apply(AnchorNode anchorNode)
        {
            System.Console.WriteLine("Highlight Anchor");
        }
    }
}