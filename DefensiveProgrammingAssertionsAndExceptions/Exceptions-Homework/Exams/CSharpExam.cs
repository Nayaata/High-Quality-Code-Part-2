﻿namespace Exceptions
{
    using System;

    public class CSharpExam : Exam
    {
        private int score;

        public CSharpExam(int score)
        {
            this.Score = score;
        }

        public int Score
        {
            get
            {
                return this.score;
            }
            private set
            {
                if (Score < 0 || Score > 100)
                {
                    throw new ArgumentException("The score should be in range between zero and 100!");
                }

                this.score = value;
            }
        }

        public override ExamResult CheckExamScore()
        {
            return new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
        }
    }
}
