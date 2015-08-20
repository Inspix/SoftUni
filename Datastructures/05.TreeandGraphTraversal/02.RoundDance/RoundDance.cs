using _01.FindTheRoot;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.RoundDance
{
    class RoundDance
    {
        static Dictionary<int, Tree<int>> nodes;
        static List<int> visited;
        static int lenght = 1;
        static void Main(string[] args)
        {
            List<string[]> input = new List<string[]>
            {
                new string[] {"8","1","1 2","1 3","4 5","7 8","1 7","7 9","8 11","4 1"},
                new string[] {"8","7","1 2","1 3","4 5","7 8","1 7","7 9","8 11","4 1"}
            };

            foreach (var test in input)
            {
                Console.WriteLine("----Test----");
                Console.WriteLine(string.Join(", ", test));
                Console.WriteLine("---Result---");
                MainProgram(test);
                Console.WriteLine();
            }
        }

        static void MainProgram(string[] input)
        {
            nodes = new Dictionary<int, Tree<int>>();
            visited = new List<int>();

            int n = int.Parse(input[0]);
            int start = int.Parse(input[1]);
            for (int i = 2; i < n + 2; i++)
            {
                int[] values = input[i].Split().Select(int.Parse).ToArray();
                var node = FindTheRoot.FindNodeWithValue(nodes, values[0]);
                var child = FindTheRoot.FindNodeWithValue(nodes, values[1]);
                node.Childs.Add(child);
                child.Childs.Add(node);
            }

            Console.WriteLine(FindLongestRoute(FindTheRoot.FindNodeWithValue(nodes, start)));
        }

        static int FindLongestRoute(Tree<int> node)
        {
            
            if (!visited.Contains(node.Value))
            {
                visited.Add(node.Value);
                lenght = 1;
                foreach (var child in node.Childs)
                {
                    FindLongestRoute(child);
                }
                lenght++;
            }
            return lenght;
        }
    }
}

