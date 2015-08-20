using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Dictionary
{
    public class HashTable<TKey,TValue> : IEnumerable<KeyValue<TKey,TValue>>
    {

        public const int InitialCapacity = 16;

        private LinkedList<KeyValue<TKey, TValue>>[] slots;

        public HashTable(int capacity = InitialCapacity)
        {
            this.slots = new LinkedList<KeyValue<TKey, TValue>>[capacity];
        }

        public int Count { get; private set; } = 0;

        public int Capacity { get { return this.slots.Length; } }

        public TValue this[TKey key]
        {
            get { return this.Get(key); }
            set
            {
                AddOrReplace(key, value);
            }
        }

        private void GrowCheck()
        {
            if (Count + 1 == Capacity)
            {
                var oldValues = this.slots;
                this.slots = new LinkedList<KeyValue<TKey, TValue>>[Capacity * 2];
                this.Count = 0;
                foreach (var item in oldValues)
                {
                    if (item == null)
                    {
                        continue;
                    }
                    foreach (var pair in item)
                    {
                        this.Add(pair.Key, pair.Value);
                    }
                }
            }
            
        }

        private int FindIndex(TKey key)
        {
            int toReturn = key.GetHashCode();
            return Math.Abs(toReturn % Capacity);
        }


        public void Add(TKey key,TValue value)
        {
            GrowCheck();
            int index = this.FindIndex(key);
            if (this.slots[index] == null)
            {
                this.slots[index] = new LinkedList<KeyValue<TKey, TValue>>();
            }
            foreach (var item in slots[index])
            {
                if (item.Key.Equals(key))
                {
                    throw new ArgumentException("Key already exists: " + key);
                }
            }

            var element = new KeyValue<TKey, TValue>(key, value);
            this.slots[index].AddLast(element);
            this.Count++;
            
        }

        public void AddOrReplace(TKey key, TValue value)
        {
            int index = this.FindIndex(key);
            if (this.slots[index] == null)
            {
                this.slots[index] = new LinkedList<KeyValue<TKey, TValue>>();
            }
            foreach (var item in slots[index])
            {
                if (item.Key.Equals(key))
                {
                    item.Value = value;
                    return;
                }
            }

            var element = new KeyValue<TKey, TValue>(key, value);
            this.slots[index].AddLast(element);
            this.Count++;
        }

        public IEnumerable<TKey> Keys
        {
            get
            {
                var enumerator = this.GetEnumerator();
                if (enumerator.Current != null)
                {
                    yield return enumerator.Current.Key;
                }
                while (enumerator.MoveNext())
                {
                    yield return enumerator.Current.Key;
                }
            }
        }

        public IEnumerable<TValue> Values
        {
            get {
                var enumerator = this.GetEnumerator();
                if (enumerator.Current != null)
                {
                    yield return enumerator.Current.Value;
                }
                while (enumerator.MoveNext())
                {
                    yield return enumerator.Current.Value;
                }
            }
        }

        public KeyValue<TKey,TValue> Find(TKey key)
        {
            int index = this.FindIndex(key);
            var value = this.slots[index];
            if (value != null)
            {
                foreach (var element in value)
                {
                    if (element.Key.Equals(key))
                    {
                        return element;
                    }
                }
            }
            return null;
            
        }

        public TValue Get(TKey key)
        {
            var element = this.Find(key);
            if (element == null)
            {
                throw new KeyNotFoundException("The key '" + key + "' does not exist");
            }
            return element.Value;
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            var element = this.Find(key);
            if (element == null)
            {
                value = default(TValue);
                return false;
            }
            value = element.Value;
            return true;
        }

        public bool ContainsKey(TKey key)
        {
            var index = FindIndex(key);
            if (slots[index] == null)
            {
                return false;
            }
            foreach (var item in slots[index])
            {
                if (item.Key.Equals(key))
                {
                    return true;
                }
            }
            return false;
        }

        public void Clear()
        {
            for (int i = 0; i < slots.Length; i++)
            {
                slots[i] = null;
            }
            this.Count = 0;
        }

        public bool Remove(TKey key)
        {
            var index = this.FindIndex(key);
            var element = this.slots[index];
            if (element == null)
            {
                return false;
            }
            var check = element.First;

            while (check != null)
            {
                if (check.Value.Key.Equals(key))
                {
                    slots[index].Remove(check);
                    this.Count--;
                    return true;
                }
                check = check.Next;
            }
            return false;
        }


        public List<KeyValue<TKey,TValue>> ToList()
        {
            var result = new List<KeyValue<TKey, TValue>>();
            foreach (var list in slots)
            {
                if (list == null)
                {
                    continue;
                }
                foreach (var pair in list)
                {
                    result.Add(pair);
                }
            }
            return result;
        }

        public IEnumerator<KeyValue<TKey, TValue>> GetEnumerator()
        {
            foreach (var list in slots)
            {
                if (list == null)
                {
                    continue;
                }                   

                foreach (var pair in list)
                {
                    yield return pair;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
