using Matrix.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrica.Tests.Fakes
{
    public class LoggerFake : ILogger
    {
        public LoggerFake()
        {
            this.Text = new StringBuilder();
        }

        public StringBuilder Text { get; private set; }

        public void Write(string text)
        {
            this.Text.Append(text);
        }

        public void WriteLine(string text)
        {
            this.Text.Append(text);
        }
    }
}
