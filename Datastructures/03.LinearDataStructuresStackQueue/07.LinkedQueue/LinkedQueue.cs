namespace _07.LinkedQueue
{
    public class LinkedQueue<T>
    {
        private QueueNode<T> headNode;
        private QueueNode<T> tailNode; 

        public int Count { get; private set; } = 0;

        public void Enqueue(T element)
        {
            
            if (this.headNode == null && tailNode == null)
            {
                headNode = new QueueNode<T>(element);
                tailNode = headNode;
                headNode.NextNode = tailNode;
                tailNode.PreviousNode = headNode;
                Count++;
                return;
            }
            tailNode.NextNode = new QueueNode<T>(element,tailNode);
            tailNode = tailNode.NextNode;
            Count++;
        }

        public T Dequeue()
        {
            T toReturn = headNode.Value;
            headNode = headNode.NextNode;
            Count--;
            return toReturn;
        }

        public T[] ToArray()
        {
            T[] result = new T[Count];
            QueueNode<T> temp = headNode;
            for (int i = 0; i < Count; i++)
            {
                result[i] = temp.Value;
                temp = temp.NextNode;
                }
            return result;

        }

        private class QueueNode<T>
        {
            public T Value { get; }
            public QueueNode<T> PreviousNode { get; set; }
            public QueueNode<T> NextNode { get; set; }

            public QueueNode(T value, QueueNode<T> prevNode = null, QueueNode<T> nextNode = null)
            {
                this.Value = value;
                this.PreviousNode = prevNode;
                this.NextNode = nextNode;
            }
        }
    }
}
