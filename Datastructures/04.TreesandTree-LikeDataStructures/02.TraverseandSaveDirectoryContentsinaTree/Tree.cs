using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.TraverseandSaveDirectoryContentsinaTree
{
    public class Tree<T> where T: IEquatable<T>
    {
        public T Value { get; set; }
        public Tree<T> Parent { get; set; }
        public IList<Tree<T>> Children { get; private set; }

        public Tree(T value, params Tree<T>[] children)
        {
            this.Value = value;
            this.Children = new List<Tree<T>>();
            foreach(Tree<T> child in children)
            {
                this.Children.Add(child);
                child.Parent = this;
            }
        }
        
        public void AddChild(Tree<T> child)
        {
            this.Children.Add(child);
            child.Parent = this;
        }

        public Tree<T> FindSubTree(T item)
        {
            Stack<Tree<T>> nodes = new Stack<Tree<T>>();
            Stack<Tree<T>> newNodes = new Stack<Tree<T>>();
            foreach (var child in Children)
            {
                newNodes.Push(child);
            }
            while (newNodes.Count > 0)
            {
                nodes = newNodes;
                newNodes = new Stack<Tree<T>>();
                while (nodes.Count > 0)
                {
                    var node = nodes.Pop();
                    if (node.Value.Equals(item))
                    {
                        return node;
                    }
                    else
                    {
                        FindSubTreeHelper(newNodes, node, item);
                    }
                }
            }
            return null;
        }

        private void FindSubTreeHelper(Stack<Tree<T>> stack, Tree<T> node, T item)
        {
            foreach (var child in node.Children)
            {
                if (child.Value.Equals(item))
                {
                    break;
                }
                else
                {
                    stack.Push(child);
                }
            }
        }
    }
}
