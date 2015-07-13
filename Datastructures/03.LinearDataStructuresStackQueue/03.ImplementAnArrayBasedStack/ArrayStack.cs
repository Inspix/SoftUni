using System;
using System.Collections;
using System.Collections.Generic;

namespace ImplementAnArrayBasedStack
{
    public class ArrayStack<T>
    {
        private const int InitialCapacity = 16;
        private T[] elements;
        public ArrayStack(int capacity = InitialCapacity)
        {
            this.elements = new T[capacity];
            this.Count = 0;
        }

        public int Count { get; private set; }

        public void Push(T item)
        {
            if (Count == this.elements.Length)
            {
                this.Grow();
            }
            this.elements[Count++] = item;
        }

        public T Pop()
        {
            return this.elements[--Count];
        }

        public T[] ToArray()
        {
            T[] toReturn = new T[Count];
            int index = 0;
            for (int i = Count-1; i >= 0; i--)
            {
                toReturn[index++] = elements[i];
            }
            return toReturn;
        }

        private void Grow()
        {
            T[] newArray = new T[elements.Length*2];
            Array.Copy(this.elements,newArray,this.elements.Length);
            this.elements = newArray;
        }
    }
}
