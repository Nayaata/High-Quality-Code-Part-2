namespace Exceptions
{
    using System;

    public class ExamResult
    {
        private int grade;
        private int minGrade;
        private int maxGrade;
        private string comments;

        public ExamResult(int grade, int minGrade, int maxGrade, string comments)
        {
            this.Grade = grade;
            this.MinGrade = minGrade;
            this.MaxGrade = maxGrade;
            this.Comments = comments;
        }

        public int Grade 
        {
            get
            {
                return this.grade;
            }
            private set
            {
                if (grade < 0)
                {
                    throw new ArgumentException("The grade cannot be less than zero!");
                }

                this.grade = value;
            }
        }

        public int MinGrade 
        {
            get
            {
                return this.minGrade;
            }
            set
            {
                if (minGrade < 0)
                {
                    throw new ArgumentException("The minimum grade cannot be less than zero!");
                }

                this.minGrade = value;
            }
        }

        public int MaxGrade 
        {
            get
            {
                return this.maxGrade;
            }
            set
            {
                if (maxGrade <= minGrade)
                {
                    throw new ArgumentException("The maximum grade cannot be less than minimum grade!");
                }

                this.maxGrade = value;
            }
        }

        public string Comments
        {
            get
            {
                return this.comments;
            }
            set
            {
                if (comments == null || comments == "")
                {
                    throw new NullReferenceException("the given comments cannot be null or empty value!");
                }

                this.comments = value;
            }
        }
    }
}