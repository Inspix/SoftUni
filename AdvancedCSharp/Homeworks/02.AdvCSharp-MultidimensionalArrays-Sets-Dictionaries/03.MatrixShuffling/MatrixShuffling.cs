using System;
using System.Linq;

class MatrixShuffling
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());

        string[,] matrix = new string[n, m];

        int row = matrix.GetUpperBound(0);
        int col = matrix.GetUpperBound(1);
        for (int x = 0; x <= row; x++)
        {
            for (int y = 0; y <= col; y++)
            {
                string input = Console.ReadLine();
                matrix[x, y] = input;
            }
        }

        string command = Console.ReadLine();

        do
        {
            int[] coordinates = null;
            if (ValidateCommand(command, row, col, out coordinates))
            {
                Swap(ref matrix[coordinates[0], coordinates[1]], ref matrix[coordinates[2], coordinates[3]]);
                PrintMatrix(matrix);
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
            command = Console.ReadLine();
        } while (command != "END");
    }

    static void Swap(ref string x, ref string y)
    {
        string temp = x;
        x = y;
        y = temp;
    }

    static bool ValidateCommand(string x, int rows, int cols, out int[] coordinates)
    {
        coordinates = null;
        if (x.Length < 4)
        {
            return false;
        }
        string command = x.Substring(0, 4);
        x = x.Remove(0, 4);
        if (command != "swap")
        {
            return false;
        }
        coordinates = x.Split(new char[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        if (coordinates.Length != 4) return false;
        else if ((coordinates[0] > rows || coordinates[0] < 0) || (coordinates[2] > rows || coordinates[2] < 0)) return false;
        else if ((coordinates[1] > cols || coordinates[1] < 0) || (coordinates[3] > cols || coordinates[3] < 0)) return false;
        return true;
    }

    static void PrintMatrix(string[,] matrix)
    {
        int row = 0;
        foreach (string i in matrix)
        {
            if (++row % matrix.GetLength(1) == 0)
            {
                Console.WriteLine(i);
            }
            else
            {
                Console.Write(i + " ");
            }
        }
    }
}

