using System;
using System.Collections;

namespace _02.PerformanceOfOperations
{
    public static class TestMethods
    {
        private static int Itterations { get; set; }

        public static PerformanceTable TestAll(int iterations)
        {
            Itterations = iterations;
            PerformanceTable table = new PerformanceTable("n=" + iterations);
            
            PerformTest(ref table,PlusTests,TestType.Plus);
            PerformTest(ref table, MinusTests, TestType.Minus);
            PerformTest(ref table,PlusPrefixTests,TestType.PlusPrefix);
            PerformTest(ref table, PlusPostfixTests, TestType.PlusPostfix);
            PerformTest(ref table, PlusEqualsTests, TestType.PlusEquals);
            PerformTest(ref table, MultiplyTests, TestType.Multiply);
            PerformTest(ref table, DivideTests, TestType.Divide);
            PerformTest(ref table, SqrtTests, TestType.Sqrt);
            PerformTest(ref table, LogTests, TestType.Log);
            PerformTest(ref table, SinTests, TestType.Sin);

            return table;
        }

        private static void PerformTest(ref PerformanceTable table, IEnumerable tests, TestType type)
        {
            foreach (Test test in tests)
            {
                test.PerformTest();
                PerformanceTime currentTest = new PerformanceTime(test.TypeToTest, test.TimeResult, type);
                table.AddTest(currentTest);
            }
        }


        public static IEnumerable PlusTests
        {
            get
            {
                yield return new Test(Plus.Int);
                yield return new Test(Plus.Long);
                yield return new Test(Plus.Double);
                yield return new Test(Plus.Decimal);
            }
        }

        public static IEnumerable MinusTests
        {
            get
            {
                yield return new Test(Minus.Int);
                yield return new Test(Minus.Long);
                yield return new Test(Minus.Double);
                yield return new Test(Minus.Decimal);
            }
        }

        public static IEnumerable PlusPostfixTests
        {
            get
            {
                yield return new Test(PlusPostfix.Int);
                yield return new Test(PlusPostfix.Long);
                yield return new Test(PlusPostfix.Double);
                yield return new Test(PlusPostfix.Decimal);
            }
        }

        public static IEnumerable PlusPrefixTests
        {
            get
            {
                yield return new Test(PlusPrefix.Int);
                yield return new Test(PlusPrefix.Long);
                yield return new Test(PlusPrefix.Double);
                yield return new Test(PlusPrefix.Decimal);
            }
        }

        public static IEnumerable PlusEqualsTests
        {
            get
            {
                yield return new Test(PlusEquals.Int);
                yield return new Test(PlusEquals.Long);
                yield return new Test(PlusEquals.Double);
                yield return new Test(PlusEquals.Decimal);
            }
        }

        public static IEnumerable MultiplyTests
        {
            get
            {
                yield return new Test(Multiply.Int);
                yield return new Test(Multiply.Long);
                yield return new Test(Multiply.Double);
                yield return new Test(Multiply.Decimal);
            }
        }

        public static IEnumerable DivideTests
        {
            get
            {
                yield return new Test(Divide.Int);
                yield return new Test(Divide.Long);
                yield return new Test(Divide.Double);
                yield return new Test(Divide.Decimal);
            }
        }

        public static IEnumerable SqrtTests
        {
            get
            {
                yield return new Test(null);
                yield return new Test(null);
                yield return new Test(Sqrt.Double);
                yield return new Test(Sqrt.Decimal);
            }
        }

        public static IEnumerable LogTests
        {
            get
            {
                yield return new Test(null);
                yield return new Test(null);
                yield return new Test(Log.Double);
                yield return new Test(Log.Decimal);
            }
        }

        public static IEnumerable SinTests
        {
            get
            {
                yield return new Test(null);
                yield return new Test(null);
                yield return new Test(Sin.Double);
                yield return new Test(Sin.Decimal);
            }
        }

        private static class Plus
        {
            public static Type Int()
            {
                int test = 0;
                for (int i = 0; i < Itterations; i++)
                {
                    test = test + 2;
                }
                return typeof(int);

            }
            public static Type Long()
            {
                long test = 0;
                for (int i = 0; i < Itterations; i++)
                {
                    test = test + 2;
                }
                return typeof (long);
            }
            public static Type Double()
            {
                double test = 0;
                for (int i = 0; i < Itterations; i++)
                {
                    test = test + 2;
                }
                return typeof (double);
            }

            public static Type Decimal()
            {
                decimal test = 0;
                for (int i = 0; i < Itterations; i++)
                {
                    test = test + 2;
                }
                return typeof (decimal);
            }
        }

        private static class Minus
        {
            public static Type Int()
            {
                int test = Itterations;
                int temp = 0;
                for (int i = 0; i < Itterations; i++)
                {
                    temp = test - i;
                }
                return typeof(int);

            }
            public static Type Long()
            {
                long test = Itterations;
                long temp = 0;
                for (int i = 0; i < Itterations; i++)
                {
                    temp = test - i;
                }
                return typeof(long);
            }
            public static Type Double()
            {
                double test = Itterations;
                double temp = 0;
                for (int i = 0; i < Itterations; i++)
                {
                    temp = test - i;
                }
                return typeof(double);
            }

            public static Type Decimal()
            {
                decimal test = Itterations;
                decimal temp = 0;
                for (int i = 0; i < Itterations; i++)
                {
                    temp = test - i;
                }
                return typeof(decimal);
            }
        }

        private static class PlusPostfix
        {

            public static Type Int()
            {
                int test = 0;
                for (int i = 0; i < Itterations; i++)
                {
                    test++;
                }
                return typeof(int);

            }
            public static Type Long()
            {
                long test = 0;
                for (int i = 0; i < Itterations; i++)
                {
                    test++;
                }
                return typeof(long);

            }
            public static Type Double()
            {
                double test = 0;
                for (int i = 0; i < Itterations; i++)
                {
                    test++;
                }
                return typeof(double);

            }

            public static Type Decimal()
            {
                decimal test = 0;
                for (int i = 0; i < Itterations; i++)
                {
                    test++;
                }
                return typeof (decimal);
            }
        }

        private static class PlusPrefix
        {
            public static Type Int()
            {
                int test = 0;
                for (int i = 0; i < Itterations; i++)
                {
                    ++test;
                }
                return typeof(int);

            }
            public static Type Long()
            {
                long test = 0;
                for (int i = 0; i < Itterations; i++)
                {
                    ++test;
                }
                return typeof(long);

            }
            public static Type Double()
            {
                double test = 0;
                for (int i = 0; i < Itterations; i++)
                {
                    ++test;
                }
                return typeof(double);

            }

            public static Type Decimal()
            {
                decimal test = 0;
                for (int i = 0; i < Itterations; i++)
                {
                    ++test;
                }
                return typeof(decimal);
            }
        }

        private static class PlusEquals
        {
            public static Type Int()
            {
                int test = 0;
                for (int i = 0; i < Itterations; i++)
                {
                    test += 1;
                }
                return typeof(int);

            }
            public static Type Long()
            {
                long test = 0;
                for (int i = 0; i < Itterations; i++)
                {
                    test += 1;
                }
                return typeof(long);

            }
            public static Type Double()
            {
                double test = 0;
                for (int i = 0; i < Itterations; i++)
                {
                    test += 1;
                }
                return typeof(double);

            }

            public static Type Decimal()
            {
                decimal test = 0;
                for (int i = 0; i < Itterations; i++)
                {
                    test += 1;
                }
                return typeof(decimal);
            }
        }

        private static class Multiply
        {
            public static Type Int()
            {
                int test = 0;
                for (int i = 0; i < Itterations; i++)
                {
                    test = i * 2;
                }
                return typeof(int);

            }
            public static Type Long()
            {
                long test = 0;
                for (int i = 0; i < Itterations; i++)
                {
                    test = i * 2L;
                }
                return typeof(long);

            }
            public static Type Double()
            {
                double test = 0;
                for (int i = 0; i < Itterations; i++)
                {
                    test = i * 2d;
                }
                return typeof(double);

            }

            public static Type Decimal()
            {
                decimal test = 0;
                for (int i = 0; i < Itterations; i++)
                {
                    test = i * 2m;
                }
                return typeof(decimal);
            }
        }

        private static class Divide
        {
            public static Type Int()
            {
                int test = Itterations;
                int temp = 0;
                for (int i = 1; i <= Itterations; i++)
                {
                    temp = test / i;
                }
                return typeof(int);

            }
            public static Type Long()
            {
                long test = Itterations;
                long temp = 0;
                for (int i = 1; i <= Itterations; i++)
                {
                    temp = test / i;
                }
                return typeof(long);

            }
            public static Type Double()
            {
                double test = Itterations;
                double temp = 0;
                for (int i = 1; i <= Itterations; i++)
                {
                    temp = test / i;
                }
                return typeof(double);

            }

            public static Type Decimal()
            {
                decimal test = Itterations;
                decimal temp = 0;
                for (int i = 1; i <= Itterations; i++)
                {
                    temp = test / i;
                }
                return typeof(decimal);
            }
        }

        private static class Sqrt
        {
            public static Type Double()
            {
                double test = 0;
                for (int i = 1; i <= Itterations; i++)
                {
                    test = Math.Sqrt(Itterations);
                }
                return typeof(float);

            }

            public static Type Decimal()
            {
                decimal test = 0;
                for (int i = 1; i <= Itterations; i++)
                {
                    test = (decimal)Math.Sqrt(Itterations);
                }
                return typeof(decimal);
            }
        }

        private static class Log
        {
            public static Type Double()
            {
                double test = 0;
                for (int i = 1; i <= Itterations; i++)
                {
                    test = Math.Log(Itterations);
                }
                return typeof(float);

            }

            public static Type Decimal()
            {
                decimal test = 0;
                for (int i = 1; i <= Itterations; i++)
                {
                    test = (decimal)Math.Log(Itterations);
                }
                return typeof(decimal);
            }
        }

        public static class Sin
        {
            public static Type Double()
            {
                double test = 0;
                for (int i = 1; i <= Itterations; i++)
                {
                    test = Math.Sin(Itterations);
                }
                return typeof(float);

            }

            public static Type Decimal()
            {
                decimal test = 0;
                for (int i = 1; i <= Itterations; i++)
                {
                    test = (decimal)Math.Sin(Itterations);
                }
                return typeof(decimal);
            }
        }

    }
}
