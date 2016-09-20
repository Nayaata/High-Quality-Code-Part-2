namespace Exceptions
{
    using Exceptions_Homework;
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Startup
    {
        static void Main()
        {
            var substr = HelperMethods.Subsequence("Hello!".ToCharArray(), 2, 3);
            Console.WriteLine(substr);

            var subarr = HelperMethods.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
            Console.WriteLine(String.Join(" ", subarr));

            var allarr = HelperMethods.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
            Console.WriteLine(String.Join(" ", allarr));

            var emptyarr = HelperMethods.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
            Console.WriteLine(String.Join(" ", emptyarr));

            Console.WriteLine(HelperMethods.ExtractEnding("I love C#", 2));
            Console.WriteLine(HelperMethods.ExtractEnding("Nakov", 4));
            Console.WriteLine(HelperMethods.ExtractEnding("beer", 4));
            Console.WriteLine(HelperMethods.ExtractEnding("Hi", 100));

            try
            {
                HelperMethods.CheckPrime(23);

                Console.WriteLine("The given number is prime.");
            }
            catch (ArgumentException ex)
            {
                throw new ArgumentException("The given number must be prime!", ex);
            }

            try
            {
                HelperMethods.CheckPrime(33);

                Console.WriteLine("The given number is prime.");
            }
            catch (Exception ex)
            {
                throw new ArgumentException("The given number must be prime!", ex);
            }

            List<Exam> peterExams = new List<Exam>()
            {
                new SimpleMathExam(2),
                new CSharpExam(55),
                new CSharpExam(100),
                new SimpleMathExam(1),
                new CSharpExam(0)
            };

            Student peter = new Student("Peter", "Petrov", peterExams);

            double peterAverageResult = peter.CalcAverageExamResultInPercents();

            Console.WriteLine("Average results = {0:p0}", peterAverageResult);
        }
    }
}