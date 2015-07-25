using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CalculateArithmeticExpression
{
    public class Tree<T>
    {
        public T Value { get; set; }
        public Tree<T> Parent { get; set; }
        public Tree<T> Left { get; set; }
        public Tree<T> Right { get; set; }

        public Tree(T value)
        {
            this.Value = value;
        }

                
        public IEnumerable<Tree<T>> FindLeafsDistinctParents()
        {
            Stack<Tree<T>> MiddleNodes = new Stack<Tree<T>>();
            List<Tree<T>> leafs = new List<Tree<T>>();
            if (this.Left != null)
            {
                MiddleNodes.Push(this.Left);
            }
            if(this.Right != null)
            {
                MiddleNodes.Push(this.Right);
            }
            if (this.Right == null && this.Left == null)
            {
                leafs.Add(this);
            }

            while (MiddleNodes.Count > 0)
            {
                var currentNode = MiddleNodes.Pop();
                if (currentNode.Left != null)
                {
                    MiddleNodes.Push(currentNode.Left);
                }
                if (currentNode.Right != null)
                {
                    MiddleNodes.Push(currentNode.Right);
                }
                if (currentNode.Right == null && currentNode.Left == null)
                {
                    if (leafs.Any(s =>s.Parent == currentNode.Parent))
                    {
                        continue;
                    }
                    leafs.Add(currentNode);
                }
            }
            return leafs;
        }

        public void Print(int indent = 0)
        {
            Console.WriteLine(new string(' ', 2 * indent) + this.Value);
            this.Right?.Print(indent + 1);
            this.Left?.Print(indent + 1);
        }
    }
}
