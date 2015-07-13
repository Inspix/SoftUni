using System.Runtime.Remoting.Channels;

namespace _05.LinkedStack
{
    public class LinkedStack<T>
    {
        private class Node<T>
        {
            public Node(T value, Node<T> nextNode = null)
            {
                this.Value = value;
                this.NextNode = nextNode;
            }

            public Node<T> NextNode { get; }
            public T Value { get;  }
        }

        private Node<T> first;

        public void Push(T element)
        {
            this.first = new Node<T>(element,this.first);
            this.Count++;
        }

        public T Pop()
        {
            T result = this.first.Value;
            this.first = first.NextNode;
            this.Count--;
            return result;
        }

        public T[] ToArray()
        {
            T[] result = new T[Count];
            Node<T> temp = first;
            for (int i = 0; i < Count; i++)
            {
                result[i] = temp.Value;
                temp = temp.NextNode;
            }
            return result;
        }

        public int Count { get; private set; } = 0;
    }
}
