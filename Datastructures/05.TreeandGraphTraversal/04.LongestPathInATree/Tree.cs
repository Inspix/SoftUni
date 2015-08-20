using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.LongestPathInATree
{
    public class Tree<T> where T : IEquatable<T>
    {
        public Tree<T> Parent { get; set; }
        public T Value { get; set; }
        public IList<Tree<T>> Childs { get; set; }

        public Tree(T value, params Tree<T>[] children)
        {
            this.Value = value;
            this.Childs = new List<Tree<T>>();
            foreach (var child in children)
            {
                this.Childs.Add(child);
                child.Parent = this;
            }
        }



        public IEnumerable<Tree<T>> FindLeafs()
        {
            List<T> Visited = new List<T>();
            Stack<Tree<T>> nodesToCheck = new Stack<Tree<T>>();
            foreach (var child in Childs)
            {
                nodesToCheck.Push(child);
            }

            while (nodesToCheck.Count > 0)
            {
                var node = nodesToCheck.Pop();
                if (!Visited.Contains(node.Value))
                {
                    Visited.Add(node.Value);
                    if (node.Childs.Count == 0)
                    {
                        yield return node;
                        continue;
                    }
                    foreach (var child in node.Childs)
                    {
                        nodesToCheck.Push(child);
                    }
                }
            }
        }

        
    }
}
