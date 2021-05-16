namespace Strategy
{
    // 3. Strategy Implementation
    public class JpegCompressor : ICompressor
    {
        public void Compress()
        {
            System.Console.WriteLine("Compressing using Jpeg");
        }
    }
}