namespace CompareAdvancedMaths
{
    using CompareSimpleMaths;
    using System;

    public class Startup
    {
        public static void Main()
        {
            // Square Root
            CompareAdvancedMaths.AdvancedOperationTimeMeasurer(OperationType.SquareRoot, DataType.Float);
            CompareAdvancedMaths.AdvancedOperationTimeMeasurer(OperationType.SquareRoot, DataType.Double);
            CompareAdvancedMaths.AdvancedOperationTimeMeasurer(OperationType.SquareRoot, DataType.Decimal);

            Console.WriteLine(new string('*', 78));

            // Sinus
            CompareAdvancedMaths.AdvancedOperationTimeMeasurer(OperationType.Sinus, DataType.Float);
            CompareAdvancedMaths.AdvancedOperationTimeMeasurer(OperationType.Sinus, DataType.Double);
            CompareAdvancedMaths.AdvancedOperationTimeMeasurer(OperationType.Sinus, DataType.Decimal);

            Console.WriteLine(new string('*', 78));

            // Natural Logarithm
            CompareAdvancedMaths.AdvancedOperationTimeMeasurer(OperationType.NaturalLogarithm, DataType.Float);
            CompareAdvancedMaths.AdvancedOperationTimeMeasurer(OperationType.NaturalLogarithm, DataType.Double);
            CompareAdvancedMaths.AdvancedOperationTimeMeasurer(OperationType.NaturalLogarithm, DataType.Decimal);

            Console.WriteLine(new string('*', 78));
        }
    }
}
