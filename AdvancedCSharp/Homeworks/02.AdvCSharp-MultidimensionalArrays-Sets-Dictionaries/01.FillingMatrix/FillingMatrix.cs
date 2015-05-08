using System;

class FillingMatrix
{
    static void Main()
    {
        
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        matrix = FillPattern(matrix);

        for (int x = 0; x <= matrix.GetUpperBound(0); x++)
        {
            for (int y = 0; y <= matrix.GetUpperBound(1); y++)
            {
                Console.Write(matrix[x,y] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        matrix = FillPattern(matrix, "Pattern");

        for (int x = 0; x <= matrix.GetUpperBound(0); x++)
        {
            for (int y = 0; y <= matrix.GetUpperBound(1); y++)
            {
                Console.Write(matrix[x, y] + " ");
            }
            Console.WriteLine();
        }

    }
    static int[,] FillPattern(int[,] matrix,string type= "normal")
    {
        int number = 1;
        if (type != "normal")
	    {
		    for (int x = 0; x <= matrix.GetUpperBound(1); x++)
            {
                if (x % 2 == 0)
                {
                    for (int y = 0; y <= matrix.GetUpperBound(0); y++)
                    {
                        matrix[y, x] = number;
                        number++;
                    }
                }
                else
                {
                    for (int y = matrix.GetUpperBound(0); y >=0 ; y--)
                    {
                        matrix[y, x] = number;
                        number++;
                    }
                }
            }
            return matrix;
	    }
        else
        {
            for (int x = 0; x <= matrix.GetUpperBound(1); x++)
            {
                for (int y = 0; y <= matrix.GetUpperBound(0); y++)
                {
                    matrix[y, x] = number;
                    number++;
                }
            }
            return matrix;
        }
    }
}
