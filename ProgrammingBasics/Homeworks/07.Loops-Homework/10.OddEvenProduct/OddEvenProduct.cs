using System;

internal class OddEvenProduct
{
    private static void Main(string[] args)
    {
        string[] numbers = Console.ReadLine().Split(' ');

        int oddProduct = 0;
        int evenProduct = 0;
        for (int i = 1; i <= numbers.Length; i++)
        {
            if (i % 2 == 0)
            {
                if (evenProduct == 0)
                {
                    evenProduct = Convert.ToInt32(numbers[i - 1]);
                }
                else
                {
                    evenProduct *= Convert.ToInt32(numbers[i - 1]);
                }
            }
            else
            {
                if (oddProduct == 0)
                {
                    oddProduct = Convert.ToInt32(numbers[i - 1]);
                }
                else
                {
                    oddProduct *= Convert.ToInt32(numbers[i - 1]);
                }
            }
        }
        if (oddProduct == evenProduct)
        {
            Console.WriteLine("yes");
            Console.WriteLine("product = {0}", oddProduct);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd_product = {0}", oddProduct);
            Console.WriteLine("even_product = {0}", evenProduct);
        }
    }
}