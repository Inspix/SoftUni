namespace AATree
{
    using System;

    public class AATree<T> where T : IComparable<T>
    {
        private class AANode
        {
            public T Element;

            public AANode Left;

            public AANode Right;

            public int Level;

            public AANode()
            {
                this.Left = null;
                this.Right = null;
                this.Level = 1;
            }

            public AANode(T element, AANode left, AANode right, int level = 1)
            {
                this.Element = element;
                this.Left = left;
                this.Right = right;
                this.Level = level;
            }
        }

        private AANode nullPtr;

        private AANode root;

        public AATree()
        {
            this.nullPtr = new AANode();
            this.nullPtr.Left = this.nullPtr.Right = this.nullPtr;
            this.nullPtr.Level = 0;
            this.root = this.nullPtr;
        }

        public int Count { get; private set; } = 0;

        public bool Contains(T element)
        {
            AANode current = this.root;
            this.nullPtr.Element = element;

            while (true)
            {
                if (element.CompareTo(current.Element) < 0)
                {
                    current = current.Left;
                }
                else if (element.CompareTo(current.Element) > 0)
                {
                    current = current.Right;
                }
                else
                {
                    return current != this.nullPtr;
                }
            }
        }

        public void Insert(T element)
        {
            this.Insert(element, ref this.root);
        }

        private void Insert(T element, ref AANode node)
        {
            if (node == this.nullPtr)
            {
                node = new AANode(element, this.nullPtr, this.nullPtr);
                this.Count++;
            }
            else if (element.CompareTo(this.root.Element) < 0)
            {
                this.Insert(element, ref node.Left);
            }
            else if (element.CompareTo(this.root.Element) > 0)
            {
                this.Insert(element, ref node.Right);
            }
            else
            {
                return;
            }


            this.Skew(ref node);
            this.Split(ref node);
        }

        public void Remove(T element)
        {
            this.Remove(element, ref this.root);
        }

        private static AANode last, deletedNode;

        private void Remove(T element, ref AANode node)
        {
            if (node != this.nullPtr)
            {
                last = node;
                if (element.CompareTo(node.Element) < 0)
                {
                    this.Remove(element, ref node.Left);
                }
                else
                {
                    deletedNode = node;
                    this.Remove(element, ref node.Right);
                }
                if (node == last)
                {
                    if (deletedNode == this.nullPtr || element.CompareTo(deletedNode.Element) != 0)
                    {
                        return;
                    }
                    deletedNode.Element = node.Element;
                    deletedNode = this.nullPtr;
                    node = node.Right;
                    last = null;
                    this.Count--;
                }
                else if (node.Left.Level < node.Level - 1 || node.Right.Level < node.Level - 1)
                {
                    node.Level--;
                    if (node.Right.Level > node.Level)
                        node.Right.Level = node.Level;
                    this.Skew(ref node);
                    this.Skew(ref node.Right);
                    this.Skew(ref node.Right.Right);
                    this.Split(ref node);
                    this.Split(ref node.Right);
                }
            }
        }

        public void Clear()
        {
            this.root = this.nullPtr;
            this.Count = 0;
        }

        public void PrintTree()
        {
            if (this.root == this.nullPtr)
            {
                Console.WriteLine("Empty tree!");
                return;
            }
            this.PrintTree(this.root);

        }

        private void PrintTree(AANode node)
        {
            if (node != this.nullPtr)
            {
                this.PrintTree(node.Left);
                Console.WriteLine(node.Element);
                this.PrintTree(node.Right);
            }
        }

        public T Min()
        {
            AANode temp = this.root;
            while (temp.Left != this.nullPtr)
            {
                temp = temp.Left;
            }
            return temp.Element;
        }

        public T Max()
        {
            AANode temp = this.root;
            while (temp.Right != this.nullPtr)
            {
                temp = temp.Right;
            }
            return temp.Element;
        }

        void Skew(ref AANode node)
        {
            if (node.Left.Level == node.Level)
                this.RotateWithLeftChild(ref node);
        }

        void Split(ref AANode node)
        {
            if (node.Right.Right.Level == node.Level)
            {
                this.RotateWithRightChild(ref node);
                node.Level++;
            }
        }

        void RotateWithLeftChild(ref AANode node)
        {
            AANode temp = node.Left;
            node.Left = temp.Right;
            temp.Right = node;
            node = temp;
        }

        void RotateWithRightChild(ref AANode node)
        {
            AANode temp = node.Right;
            node.Right = temp.Left;
            temp.Left = node;
            node = temp;
        }
    }
}