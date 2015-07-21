using System;

namespace Methods
{
    class Methods
    {
        static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("The triangle sides should be positive numbers.");
            }
            double halfPerimeter = (a + b + c) / 2;
            double area = Math.Sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));
            return area;
        }

        static string NumberToWord(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
            }
            throw new ArgumentException("The passed argument should be non negative one digit number");
        }

        static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentNullException(nameof(elements),"The passed parameters cannot be null or empty.");
            }
            int temp = elements[0];
            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > temp)
                {
                    temp = elements[i];
                }
            }
            return temp;
        }

        static void PrintNumberWithFormat(object number, string format)
        {
            if (number is int || number is long || number is float || number is double || number is decimal || number is short || number is byte)
            {
                if (format == "f")
                {
                    Console.WriteLine("{0:f2}", number);
                }
                if (format == "%")
                {
                    Console.WriteLine("{0:p0}", number);
                }
                if (format == "r")
                {
                    Console.WriteLine("{0,8}", number);
                }
                return;
            }
            throw new ArgumentException("The object must be of nummeric type.",nameof(number));
            
        }


        static double CalcDistance(double x1, double y1, double x2, double y2, 
            out bool isHorizontal, out bool isVertical)
        {
            isHorizontal = (Math.Abs(y1 - y2) < double.Epsilon);
            isVertical = (Math.Abs(x1 - x2) < double.Epsilon);

            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        static void Main()
        {
            Console.WriteLine(CalcTriangleArea(3, 4, 5));
            
            Console.WriteLine(NumberToWord(5));
            
            Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));
            PrintNumberWithFormat(1.3, "f");
            PrintNumberWithFormat(0.75, "%");
            PrintNumberWithFormat(2.30, "r");

            bool horizontal, vertical;
            Console.WriteLine(CalcDistance(3, -1, 3, 2.5, out horizontal, out vertical));
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);

            Student peter = new Student() { FirstName = "Peter", LastName = "Ivanov" };
            peter.OtherInfo = "From Sofia, born at 17.03.1992";

            Student stella = new Student() { FirstName = "Stella", LastName = "Markova" };
            stella.OtherInfo = "From Vidin, gamer, high results, born at 03.11.1993";

            Console.WriteLine("{0} older than {1} -> {2}",
                peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
