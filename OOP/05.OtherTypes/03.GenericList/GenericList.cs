using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.GenericList
{

    [Ver(1, 2)]
    internal class GenericList<T>
    {
        private static readonly T[] empty = new T[16];
        private int capacity = 16;
        private int size;
        private int currentPos = 0;
        private T[] elements;

        public GenericList()
        {
            this.elements = empty;
        }

        public GenericList(int size)
        {
            this.size = size;
            this.capacity = size;
            this.currentPos = size - 1;
            this.elements = new T[size];

        }

        public T this[int i]
        {
            get
            {
                if (i >= size)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return this.elements[i];
            }
            set
            {
                if (i >= size)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.elements[i] = value;
            }
        }

        public int Count
        {
            get { return this.size; }
        }

        public int FindIndexOf(T value)
        {
            int index = -1;

            int x = 0;
            foreach (var element in elements)
            {
                if (EqualityComparer<T>.Default.Equals(element, value))
                {
                    index = x;
                    break;
                }
                x++;
            }

            return index;
        }

        public bool Contains(T value)
        {
            return elements.Any(element => EqualityComparer<T>.Default.Equals(element, value));
        }

        public void Add(T item)
        {
            size++;
            elements[currentPos] = item;
            if (currentPos++ >= capacity)
            {
                IncreaseCapacity(false);
            }
        }


        public void Insert(T item, int index)
        {
            if (index < 0 || index > size)
            {
                throw new IndexOutOfRangeException("Index given is out of range..", new Exception("GenericList Insert"));
            }
            else
            {
                if (size + 1 > capacity)
                {
                    IncreaseCapacity(false);
                }
                T[] renew = new T[capacity];
                int oldIndex = 0;
                for (int i = 0; i <= size; i++)
                {
                    if (i == index)
                    {
                        renew[oldIndex] = item;
                        oldIndex++;
                    }
                    renew[oldIndex] = elements[i];
                    oldIndex++;
                }
                elements = renew;
                size++;
            }
        }

        public T Min()
        {
            if (size <= 0)
            {
                throw new NullReferenceException("The generic list does not contain any values..");
            }

            var toTest = elements.Take(size);
            return toTest.Min();
        }

        public T Max()
        {
            if (size <= 0)
            {
                throw new NullReferenceException("The generic list does not contain any values..");

            }
            var toTest = elements.Take(size);
            return toTest.Max();
        }


        public void Remove(int index)
        {
            if (index > size)
            {
                throw new IndexOutOfRangeException("Index given is out of range..");
            }
            else
            {
                T[] renew = new T[capacity];
                int oldIndex = 0;
                for (int i = 0; i < this.size; i++)
                {
                    if (i == index) continue;
                    renew[oldIndex] = this.elements[i];
                    oldIndex++;

                }
                size--;
                elements = renew;
            }
        }

        public void Clear()
        {
            this.elements = new T[capacity];
            this.size = 0;
        }

        public void IncreaseCapacity(bool empty)
        {
            T[] renew = new T[capacity * 2];
            if (empty)
            {
                capacity *= 2;
                elements = renew;
                return;
            }
            Array.Copy(elements, renew, elements.Length);
            capacity = capacity * 2;
            elements = renew;
        }

        public override string ToString()
        {
            T[] toPrint = new T[size];
            Array.Copy(elements, toPrint, size);

            return string.Join(", ", toPrint);
        }
    }
}
