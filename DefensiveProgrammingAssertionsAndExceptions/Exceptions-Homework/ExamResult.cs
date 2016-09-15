using System;

public class ExamResult
{
    public int Grade { get; private set; }
    public int MinGrade { get; private set; }
    public int MaxGrade { get; private set; }
    public string Comments { get; private set; }

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        if (grade < 0)
        {
            throw new ArgumentException("The grade cannot be less than zero!");
        }
        if (minGrade < 0)
        {
            throw new ArgumentException("The minimum grade cannot be less than zero!");
        }
        if (maxGrade <= minGrade)
        {
            throw new ArgumentException("The maximum grade cannot be less than minimum grade!");
        }
        if (comments == null || comments == "")
        {
            throw new NullReferenceException("the given comments cannot be null or empty value!");
        }

        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }
}
