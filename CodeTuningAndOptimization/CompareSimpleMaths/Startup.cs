using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareSimpleMaths
{
    public static class Startup
    {
        static void Main(string[] args)
        {
            // Add
            CompareSimpleMath.OperationTimeMeasurer(DataType.Int, OperationType.Add);
            CompareSimpleMath.OperationTimeMeasurer(DataType.Long, OperationType.Add);
            CompareSimpleMath.OperationTimeMeasurer(DataType.Float, OperationType.Add);
            CompareSimpleMath.OperationTimeMeasurer(DataType.Double, OperationType.Add);
            CompareSimpleMath.OperationTimeMeasurer(DataType.Decimal, OperationType.Add);

            Console.WriteLine(new string('*', 71));
            // Substract
            CompareSimpleMath.OperationTimeMeasurer(DataType.Int, OperationType.Subtract);
            CompareSimpleMath.OperationTimeMeasurer(DataType.Long, OperationType.Subtract);
            CompareSimpleMath.OperationTimeMeasurer(DataType.Float, OperationType.Subtract);
            CompareSimpleMath.OperationTimeMeasurer(DataType.Double, OperationType.Subtract);
            CompareSimpleMath.OperationTimeMeasurer(DataType.Decimal, OperationType.Subtract);

            Console.WriteLine(new string('*', 71));
            // Divide
            CompareSimpleMath.OperationTimeMeasurer(DataType.Int, OperationType.Divide);
            CompareSimpleMath.OperationTimeMeasurer(DataType.Long, OperationType.Divide);
            CompareSimpleMath.OperationTimeMeasurer(DataType.Float, OperationType.Divide);
            CompareSimpleMath.OperationTimeMeasurer(DataType.Double, OperationType.Divide);
            CompareSimpleMath.OperationTimeMeasurer(DataType.Decimal, OperationType.Divide);

            Console.WriteLine(new string('*', 71));
            // Multiply
            CompareSimpleMath.OperationTimeMeasurer(DataType.Int, OperationType.Multiply);
            CompareSimpleMath.OperationTimeMeasurer(DataType.Long, OperationType.Multiply);
            CompareSimpleMath.OperationTimeMeasurer(DataType.Float, OperationType.Multiply);
            CompareSimpleMath.OperationTimeMeasurer(DataType.Double, OperationType.Multiply);
            CompareSimpleMath.OperationTimeMeasurer(DataType.Decimal, OperationType.Multiply);

            Console.WriteLine(new string('*', 71));
            // Increment
            CompareSimpleMath.OperationTimeMeasurer(DataType.Int, OperationType.Increment);
            CompareSimpleMath.OperationTimeMeasurer(DataType.Long, OperationType.Increment);
            CompareSimpleMath.OperationTimeMeasurer(DataType.Float, OperationType.Increment);
            CompareSimpleMath.OperationTimeMeasurer(DataType.Double, OperationType.Increment);
            CompareSimpleMath.OperationTimeMeasurer(DataType.Decimal, OperationType.Increment);

            Console.WriteLine(new string('*', 71));
        }
    }
}
