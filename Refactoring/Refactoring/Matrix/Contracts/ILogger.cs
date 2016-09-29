namespace Matrix.Contracts
{
    public interface ILogger
    {
        void Write(string text);
        void WriteLine(string text);
    }
}
