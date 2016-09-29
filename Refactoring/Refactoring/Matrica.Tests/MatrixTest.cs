namespace Matrica.Tests
{
    using Fakes;
    using Matrix.Contracts;
    using Matrix.Models;
    using Moq;
    using NUnit.Framework;
    using System;

    public class MatrixTest
    {
        [TestFixture]
        public class MatrixWalkTest
        {
            [TestCase(0)]
            [TestCase(101)]
            [TestCase(-51214)]
            [TestCase(215121)]
            public void StartMatrixWalk_InvalidCellSize_ShouldThrow(int invalidCellSize)
            {
                var mockedLogger = new Mock<ILogger>();
                Assert.Throws<OverflowException>(() => Matrix.StartMatrixWalk(invalidCellSize, mockedLogger.Object));
            }

            [Test]
            public void StartMatrixWalk_InvalidLogger_ShouldThrow()
            {
                int cellSize = 50;
                Assert.Throws<ArgumentNullException>(() => Matrix.StartMatrixWalk(cellSize, null));
            }

            [Test]
            public void StartMatrixWalk_ValidParams_ShouldPrintCorrect()
            {
                int cellSize = 6;
                string expectedText = "  1 28 29 31 35 36 27  2 24 30 32 34 26 25  3 23 22 33 13 15 17  4 19 21 12 14 16 18  5 20 11 10  9  8  7  6";
                var loggerMock = new LoggerFake();

                Matrix.StartMatrixWalk(cellSize, loggerMock);

                Assert.AreEqual(expectedText, loggerMock.Text.ToString());
            }
        }
    }
}
