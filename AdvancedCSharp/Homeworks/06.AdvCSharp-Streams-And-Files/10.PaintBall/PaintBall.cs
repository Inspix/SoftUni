using System;
using System.Linq;

internal class PaintBall
{
    private static void Main(string[] args)
    {
        int[] canvas = new int[] {1023, 1023, 1023, 1023, 1023, 1023, 1023, 1023, 1023, 1023};
        string input = Console.ReadLine();
        int index = 0;
        while (input != "End")
        {
            int[] coords = input.Split().Select(int.Parse).ToArray();

            int startingX = coords[0] - coords[2];
            int startingY = coords[1] - coords[2];
            int endingX = coords[0] + coords[2];
            int endinxY = coords[1] + coords[2];

            for (int i = startingX; i <= endingX; i++)
            {
                for (int j = startingY; j <= endinxY; j++)
                {
                    if ((j < 10 && j >= 0) && (i >= 0 && i < 10))
                    {
                        if (index%2 == 0)
                        {
                            canvas[i] = canvas[i] & ~(1 << j);

                        }
                        else
                        {
                            canvas[i] = canvas[i] | (1 << j);

                        }
                    }
                }

            }
            index++;
            input = Console.ReadLine();

        }
        Console.WriteLine(canvas.Sum());
    }
}

