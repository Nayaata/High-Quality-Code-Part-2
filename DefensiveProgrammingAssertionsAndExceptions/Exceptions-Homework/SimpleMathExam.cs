using System;

public class SimpleMathExam : Exam
{
    public int ProblemsSolved { get; private set; }

    public SimpleMathExam(int problemsSolved)
    {
        if (problemsSolved < 0)
        {
            //problemsSolved = 0;
            throw new ArgumentException("The count of solved problems cannot be less than zero!");
        }
        if (problemsSolved > 10)
        {
            //problemsSolved = 10;
            throw new ArgumentException("The count of solved problems cannot be greater than ten!");
        }

        this.ProblemsSolved = problemsSolved;
    }

    public override ExamResult Check()
    {
        if (ProblemsSolved == 0)
        {
            throw new NullReferenceException("The count of solved problems cannot be less than zero! The result cannot be executed!");
            //return new ExamResult(2, 2, 6, "Bad result: nothing done.");
        }
        else
        {
            //return new ExamResult(4, 2, 6, "Average result: nothing done.");
            throw new ArgumentException("Invalid value! Average result cannot be counted!");
        }

        throw new ArgumentException("Invalid value of problems solved!");
    }
}
