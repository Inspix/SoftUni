namespace RefactoringCode
{
    using System;
    public class MatrixWalk
    {
        private int matrixSize;
        private int currentDir;
        private static readonly int[] DirectionsX = new int[] { 1, 1,  1,  0, -1, -1, -1, 0 };
        private static readonly int[] DirectionsY = new int[] { 1, 0, -1, -1, -1,  0,  1, 1 };

        public MatrixWalk(int size)
        {
            this.MatrixSize = size;
            this.Matrix = new int[matrixSize, matrixSize];
        }

        public int MatrixSize
        {
            get
            {
                return this.matrixSize;
            }
            private set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentOutOfRangeException(nameof(MatrixSize), "The matrix size should be in range [1....100]");
                }
                this.matrixSize = value;
            }
        }

        public int[,] Matrix { get; private set; }

        public void Calculate()
        {
            int currentValue = 1;
            int row = 0;
            int col = 0;

            FillMatrix(row, col, ref currentValue);

            FindEmptyCell(out row, out col);
            if (row != 0 && col != 0)
            {
                FillMatrix(row, col, ref currentValue);
            }         
        }

        public void Print()
        {
            for (int row = 0; row < Matrix.GetLength(0); row++)
            {
                for (int col = 0; col < Matrix.GetLength(1); col++)
                {
                    Console.Write("{0,4}", Matrix[row, col]);
                }

                Console.WriteLine();
            }
        }

        private bool IsValidCell(int x, int y)
        {
            return !(x >= Matrix.GetLength(0) || x < 0 || y >= Matrix.GetLength(1) || y < 0);
        }

        private bool IsValidEmptyCell(int x, int y)
        {
            return IsValidCell(x, y) && Matrix[x, y] == 0;
        }

        private void Change(ref int dX, ref int dY)
        {
            currentDir++;
            if (currentDir >= DirectionsX.Length)
            {
                currentDir = 0;
            }
            dX = DirectionsX[currentDir];
            dY = DirectionsY[currentDir];
        }

        private bool CheckForValidNeighbourCell(int x, int y)
        {
            for (int i = 0; i < 8; i++)
            {
                if (IsValidEmptyCell(x + DirectionsX[i], y + DirectionsY[i]))
                {
                    return true;
                }
            }
            return false;
        }

        private void FindEmptyCell(out int x, out int y)
        {
            x = 0;
            y = 0;
            for (int row = 0; row < Matrix.GetLength(0); row++)
            {
                for (int col = 0; col < Matrix.GetLength(0); col++)
                {
                    if (Matrix[row, col] == 0)
                    {
                        x = row;
                        y = col;
                        return;
                    }
                }
            }
        }

        private void FillMatrix(int row,int col,ref int currentValue)
        {
            int dx = 1;
            int dy = 1;
            while (CheckForValidNeighbourCell(row, col))
            {
                Matrix[row, col] = currentValue;

                while (!IsValidEmptyCell(row + dx, col + dy))
                {
                    Change(ref dx, ref dy);
                }

                row += dx;
                col += dy;
                currentValue++;
            }

            Matrix[row, col] = currentValue;
            currentValue++;
        }

    }
}
