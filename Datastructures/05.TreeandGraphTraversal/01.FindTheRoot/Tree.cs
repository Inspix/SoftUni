using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.FindTheRoot
{
    public class Tree<T>
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

        public void AddChild(T value)
        {
            var nodeToAdd = new Tree<T>(value);
            nodeToAdd.Parent = this;
        }
    }
}
