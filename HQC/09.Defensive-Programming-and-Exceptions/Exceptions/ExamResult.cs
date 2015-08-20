using System;
using System.Collections.Specialized;
using System.Runtime.Remoting.Channels;

public class ExamResult
{
    private int grade;
    private int minGrade;
    private int maxGrade;
    private string comments;

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        

        

       
        if (string.IsNullOrEmpty(comments))
        {
            
        }

        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }

    public int Grade
    {
        get { return this.grade; }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("The grade can not be negative!",nameof(Grade));
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
        private set
        {
            if (minGrade < 0)
            {
                throw new ArgumentException("The min grade can not be negative!", nameof(MinGrade));
            }
            this.minGrade = value;
        }
    }

    public int MaxGrade
    {
        get { return this.maxGrade; }
        private set
        {
            if (value < minGrade)
            {
                throw new ArgumentException("The max grade can not be smaller than min grade");
            }
            this.maxGrade = value;

        }
    }

    public string Comments
    {
        get { return this.comments; }
        private set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(nameof(Comments),"The comment can not be null or empty!");
            }
        }
    }
}
