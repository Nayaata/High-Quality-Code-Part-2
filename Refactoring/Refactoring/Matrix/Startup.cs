namespace Matrix
{
    using Models;
    public class Startup
    {
        public static void Main()
        {
            int n = 6;
            Matrix.StartMatrixWalk(n, new Logger());
        }
    }
}

