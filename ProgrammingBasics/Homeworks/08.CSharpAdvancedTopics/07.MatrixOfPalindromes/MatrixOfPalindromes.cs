using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MatrixOfPalindromes
{
    static void Main(string[] args)
    {
        string[] size = Console.ReadLine().Split(' ');
        string[,] matrix = new string[int.Parse(size[0]), int.Parse(size[1])];

        for (int x = 0; x <= matrix.GetUpperBound(0); x++)
        {
            for (int y = 0; y <= matrix.GetUpperBound(1); y++)
            {
                Console.Write(GetPalindrome(x,y+x) + " ");
            }
            Console.WriteLine();
        }

    }

    private static string GetPalindrome(int a, int b)
    {
        return string.Format("" + (char)(a + 97) + (char)(b + 97) + (char)(a + 97));
    }
}
