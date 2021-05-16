namespace Strategy
{
    // 3. Strategy Implementation
    public class PngCompressor : ICompressor
    {
        public void Compress()
        {
            System.Console.WriteLine("Compressing using Png");
        }
    }
}