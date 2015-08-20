namespace _03.PriorityQueue
{
    using System;

    public class PriorityQueue<T> where T : IComparable<T>
    {
        private T[] storage;

        private const int INITIALSIZE = 16;

        public PriorityQueue(int capacity = INITIALSIZE)
        {
            this.storage = new T[capacity];
        }

        public int Count { get; private set; } = 0;

        public int Capacity
        {
            get
            {
                return this.storage.Length - 1;
            }
        }

        public void Enqueue(T item)
        {
            if (this.Count >= this.Capacity)
            {
                this.Enlarge();
            }
            this.Count++;
            int position = this.Count;

            for (; position > 0 && item.CompareTo(this.storage[position/2]) < 0; position = position/2)
            {
                this.storage[position] = this.storage[position / 2];
            }
            this.storage[position] = item;

        }

        public T Dequeue()
        {
            T root = this.storage[1];
            this.storage[1] = this.storage[this.Count];
            this.Count--;
            int pos = 1;
            while (this.storage[pos].CompareTo(this.storage[pos*2]) > 0 
                || this.storage[pos].CompareTo(this.storage[pos*2+1]) > 0)
            {
                if (this.storage[pos*2].CompareTo(this.storage[pos*2+1]) < 0)
                {
                    this.Swap(ref this.storage[pos], ref this.storage[pos * 2]);
                    pos *= 2;
                    if (pos*2+1 >= this.Count)
                    {
                        break;
                    }
                }
                else
                {
                    this.Swap(ref this.storage[pos], ref this.storage[pos * 2 + 1]);
                    pos = pos * 2 + 1;
                    if (pos*2+1 >= this.Count)
                    {
                        break;
                    }
                }
                
            }
            return root;
        }

        private void Swap(ref T item1, ref T item2)
        {
            T temp = item1;
            item1 = item2;
            item2 = temp;
        }

        private void Enlarge()
        {
            T[] replacement = new T[this.Capacity * 2];
            Array.Copy(this.storage,replacement,this.Capacity + 1);
            this.storage = replacement;
        }
    }
}