using System;
using System.Diagnostics;

namespace _02.PerformanceOfOperations
{
    public class Test
    {
        private static Stopwatch watch;
        private Func<Type> testMethod;
        public TimeSpan TimeResult { get; private set; }


        public Test(Func<Type> method)
        {
            this.testMethod = method;
            if (watch ==null)
            {
                watch = new Stopwatch();
            }
        }

        public Type TypeToTest
        {
            get; private set;
        }

        public virtual void PerformTest()
        {
            if (testMethod == null)
            {
                return;
            }
            watch.Restart();
            var type = testMethod.Invoke();
            watch.Stop();
            this.TimeResult = watch.Elapsed;
            this.TypeToTest = type;
        }
        
    }
}
