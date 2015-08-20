using System;
using System.ComponentModel;

namespace _02.PerformanceOfOperations
{

    public enum TestType
    {
        [Description("+")]
        Plus,
        [Description("-")]
        Minus,
        [Description("++Prefix")]
        PlusPrefix,
        [Description("++Postfix")]
        PlusPostfix,
        [Description("+=")]
        PlusEquals,
        [Description("*")]
        Multiply,
        [Description("/")]
        Divide,
        [Description("Math.Sqrt()")]
        Sqrt,
        [Description("Math.Log()")]
        Log,
        [Description("Math.Sin()")]
        Sin
    }

    public class PerformanceTime
    {
        public Type TypeTested { get; private set; }
        public TimeSpan TimeElapsed { get; set; }
        public TestType Test { get; private set; }

        public PerformanceTime(Type typeTested, TimeSpan timeElapsed, TestType testType)
        {
            this.TypeTested = typeTested;
            this.TimeElapsed = timeElapsed;
            this.Test = testType;
        }

        public override string ToString()
        {
            return TypeTested.Name;
        }
    }
}
