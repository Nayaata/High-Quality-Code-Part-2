using Matrix.Contracts;
using System;

namespace Matrix.Models
{
    public class Logger : ILogger
    {
        public void Write(string text)
        {
            Console.Write(text);
        }

        public void WriteLine(string text)
        {
            Console.WriteLine(text);
        }
    }
}
