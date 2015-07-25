using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PlayWithTrees
{
    class Program
    {
        static Dictionary<int, Tree<int>> nodeByValue = new Dictionary<int, Tree<int>>();
        static void Main(string[] args)
        {
            int nodes = int.Parse(Console.ReadLine());
            for (int i = 1; i < nodes; i++)
            {
                int[] edge = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                Tree<int> parent = GetNodeByValue(edge[0]);
                Tree<int> child = GetNodeByValue(edge[1]);
                parent.Children.Add(child);
                child.Parent = parent;
            }
            int p = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());

            var longestPath = LongestPath().ToList();
            longestPath.Reverse();
            Console.WriteLine();
            Console.WriteLine("Longest Path:");
            for (int i = 0; i < longestPath.Count; i++)
            {
                Console.Write(longestPath[i].Value + (i != longestPath.Count - 1 ? "->" : "\n"));
            }
            var sums = PathsWithSum(p).ToList();
            sums.Reverse();
            Console.WriteLine();
            Console.WriteLine("Path with sum of:" + p);
            for (int i = 0; i < sums.Count; i++)
            {
                Console.Write(sums[i].Value + (i != sums.Count-1 ? "->" : "\n"));
            }
            

            var subtreeSums = SubTreesWithSum(s);
            Console.WriteLine();
            Console.WriteLine("Subtrees with sum of:" + s);
            foreach (var tree in subtreeSums)
            {
                PrintTree(tree);
            }
        }


        static void PrintTree(Tree<int> tree)
        {
            Console.WriteLine(tree.Value);
            foreach (var child in tree.Children)
            {
                Console.WriteLine("  " + child.Value);
            }
        }

        static Tree<int> FindRootNode()
        {
            return nodeByValue.Values.FirstOrDefault(s => s.Parent == null);
        }

        static IEnumerable<Tree<int>> FindMiddleNodes()
        {
            var result = nodeByValue.Values.Where(node => node.Children.Count > 0 && node.Parent != null).OrderBy(s => s.Value).ToList();
            return result;
        }

        static IEnumerable<Tree<int>> FindAllLeafs(bool sort = false)
        {
            var result = nodeByValue.Values.Where(s => s.Children.Count == 0);
            if (sort)
            {
                result = result.OrderBy(s => s.Value);
            }
            return result;
        }

        static IEnumerable<Tree<int>> PathsWithSum(int sum)
        {
            var leafs = FindAllLeafs();
            foreach (var leaf in leafs)
            {
                if (PathSum(leaf) == sum)
                {
                    var temp = leaf;
                    yield return temp;
                    while (true)
                    {
                        if (temp.Parent == null)
                        {
                            break;
                        }
                        else
                        {
                            temp = temp.Parent;
                            yield return temp;
                        }
                    }
                }
            }
        }

        static IEnumerable<Tree<int>> SubTreesWithSum(int sum)
        {
            var trees = FindMiddleNodes();
            foreach (var tree in trees)
            {
                if (TreeSum(tree) == sum)
                {
                    yield return tree;
                }
            }
        }

        static int TreeSum(Tree<int> tree)
        {
            return tree.Value + tree.Children.Select(s => s.Value).Aggregate((a, b) => a + b);
        }

        static IEnumerable<Tree<int>> LongestPath()
        {
            var leafs = FindAllLeafs().ToList();
            int maxLenght = 0;
            int maxLenghtIndex = -1;
            for (int i = 0; i < leafs.Count; i++)
            {
                var currentNode = leafs[i];
                int currentLength = 0;
                while (currentNode.Parent != null)
                {
                    currentLength++;
                    currentNode = currentNode.Parent;
                }
                if (currentLength > maxLenght)
                {
                    maxLenght = currentLength;
                    maxLenghtIndex = i;
                }
            }
            var resultNode = leafs[maxLenghtIndex];
            yield return resultNode;
            while (resultNode.Parent != null)
            {
                resultNode = resultNode.Parent;
                yield return resultNode;
            }
        }

        static int PathSum(Tree<int> leaf)
        {
            int sum = 0;
            var temp = leaf;
            while (temp.Parent != null)
            {
                sum += temp.Value;
                temp = temp.Parent;
            }
            sum += temp.Value;
            return sum;
        }

        static Tree<int> GetNodeByValue(int value)
        {
            if (!nodeByValue.ContainsKey(value))
            {
                nodeByValue[value] = new Tree<int>(value);
            }
            return nodeByValue[value];
        }
    }
}
