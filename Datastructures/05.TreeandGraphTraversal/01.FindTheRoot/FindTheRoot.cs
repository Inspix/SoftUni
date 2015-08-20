using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.FindTheRoot
{
    public class FindTheRoot
    {
        
        static void Main(string[] args)
        {
            List<string[]> testCases = new List<string[]>{
                new string[]{"6", "4 0", "3 1", "4 3", "3 6", "0 2", "1 5"},
                new string[]{"14", "11 4", "11 10", "8 11", "8 2", "9 3", "9 13", "1 9", "14 1", "0 8", "0 14", "5 6", "5 7", "14 5", "1 12"},
                new string[]{"3", "0 1", "1 0", "2 2"},
                new string[]{"3", "0 1", "1 0", "1 1"},
            };

            foreach (var test in testCases)
            {
                Console.WriteLine("------Test-------");
                Console.WriteLine(string.Join(", ",test));
                Console.WriteLine("-----Result------");
                MainProgram(test);
                Console.WriteLine();
            }
        }

        static void MainProgram(string[] input)
        {
            var nodesByValue = new Dictionary<int, Tree<int>>();
            int n = int.Parse(input[0]);

            for (int i = 1; i < n+1; i++)
            {
                int[] values = input[i].Split().Select(int.Parse).ToArray();

                var node = FindNodeWithValue(nodesByValue,values[0]);
                var child = FindNodeWithValue(nodesByValue,values[1]);
                node.Childs.Add(child);
                child.Parent = node;
                 
            }

            var root = FindRoots(nodesByValue);
            if (root.Count > 1)
            {
                Console.WriteLine("The forest is not a tree");
            }
            if (root.Count == 0)
            {
                Console.WriteLine("No root");
            }
            if (root.Count == 1)
            {
                Console.WriteLine(root[0].Value);
            }
        }

        public static List<Tree<int>> FindRoots(Dictionary<int, Tree<int>> nodes)
        {
            return nodes.Values.Where(s => s.Parent == null).ToList();
        }

        public static Tree<int> FindNodeWithValue(Dictionary <int, Tree<int>> nodes,int value)
        {
            if (nodes.ContainsKey(value))
            {
                return nodes[value];
            }
            nodes[value] = new Tree<int>(value);
            return nodes[value];
        }
    }
}
