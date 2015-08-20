using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.LongestPathInATree
{
    class Program
    {
        static Dictionary<int, Tree<int>> nodesByValue = new Dictionary<int, Tree<int>>();
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                int[] node = Console.ReadLine().Split().Select(int.Parse).ToArray();
                var parent = FindNodeByValue(node[0]);
                var child = FindNodeByValue(node[1]);
                parent.Childs.Add(child);
                child.Parent = parent;

            }
            Console.WriteLine("----Result----");
            Console.WriteLine(FindMaxLenghtSum());

        }

        static int FindMaxLenghtSum()
        {
            var leafs = FindMaxLeafWithSameParent().ToList();
            int rootValue = int.MinValue;
            int maxSum = int.MinValue;
            for (int i = 0; i < leafs.Count; i++)
            {
                int leafSum1 = 0;                

                var leafone = leafs[i];
                while (leafone.Parent != null)
                {
                    leafSum1 += leafone.Value;
                    leafone = leafone.Parent;
                }
                if (rootValue == int.MinValue)
                {
                    rootValue = leafone.Value;
                }

                int leafSum2 = 0;
                for (int j = i + 1; j < leafs.Count; j++)
                {
                    int leafMax = 0;
                    var leafTwo = leafs[j];
                    while (leafTwo.Parent != null)
                    {
                        leafMax += leafTwo.Value;
                        leafTwo = leafTwo.Parent;
                    }
                    if (leafSum2 < leafMax)
                    {
                        leafSum2 = leafMax;
                    }
                }
                int currentSum = leafSum1 + leafSum2;
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
            }
            return maxSum + rootValue;
        }

        public static IEnumerable<Tree<int>> FindMaxLeafWithSameParent()
        {
            var leafParents = FindRoot().FindLeafs().Select(s => s.Parent).ToList().Distinct();

            foreach (var parent in leafParents)
            {
                var maxChild = parent.Childs[0];
                for (int i = 1; i < parent.Childs.Count; i++)
                {
                    if (parent.Childs[i].Value > maxChild.Value)
                    {
                        maxChild = parent.Childs[i];
                    }
                }
                yield return maxChild;

            }


        }

        static Tree<int> FindRoot()
        {
            return nodesByValue.Values.First(s => s.Parent == null);
        }

        static Tree<int> FindNodeByValue(int value)
        {
            if (!nodesByValue.ContainsKey(value))
            {
                nodesByValue[value] = new Tree<int>(value);
            }
            return nodesByValue[value];
        }
    }
}
