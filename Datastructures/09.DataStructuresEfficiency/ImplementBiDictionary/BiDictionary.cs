namespace ImplementBiDictionary
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class BiDictionary<TK1,TK2,T> : IEnumerable
    {
        private Dictionary<TK1, List<T>> firstKeyDict;
        private Dictionary<TK2, List<T>> secondKeyDict;
        private Dictionary<Tuple<TK1,TK2>, List<T>> doubleKeyDict;

        public BiDictionary()
        {
            this.firstKeyDict = new Dictionary<TK1, List<T>>();
            this.secondKeyDict = new Dictionary<TK2, List<T>>();
            this.doubleKeyDict = new Dictionary<Tuple<TK1, TK2>, List<T>>();
        }



        public void Add(TK1 key1, TK2 key2, T value)
        {
            if (!this.firstKeyDict.ContainsKey(key1))
            {
                this.firstKeyDict[key1] = new List<T>() { value };
            }
            else
            {
                this.firstKeyDict[key1].Add(value);
            }

            if (!this.secondKeyDict.ContainsKey(key2))
            {
                this.secondKeyDict[key2] = new List<T>() { value };
            }
            else
            {
                this.secondKeyDict[key2].Add(value);
            }
            var tuplekey = new Tuple<TK1, TK2>(key1, key2);
            if (!this.doubleKeyDict.ContainsKey(tuplekey))
            {
                this.doubleKeyDict[tuplekey] = new List<T>() {value};
            }
            else
            {
                this.doubleKeyDict[tuplekey].Add(value);
            }
        }

        public IEnumerable<T> Find(TK1 key1, TK2 key2)
        {
            var tuple = new Tuple<TK1,TK2>(key1,key2);
            if (this.doubleKeyDict.ContainsKey(tuple))
            {
                return this.doubleKeyDict[tuple];
            }
            return null;
        }

        public IEnumerable<T> FindByKey1(TK1 key1)
        {
            if (this.firstKeyDict.ContainsKey(key1))
            {
                return this.firstKeyDict[key1];
            }
            return null;
        }

        public IEnumerable<T> FindByKey2(TK2 key2)
        {
            if (this.secondKeyDict.ContainsKey(key2))
            {
                return this.secondKeyDict[key2];
            }
            return null;
        }


        public bool Remove(TK1 key1, TK2 key2)
        {
            
            var tuple = new Tuple<TK1, TK2>(key1, key2);
            var values = this.doubleKeyDict[tuple];
            if (this.firstKeyDict[key1].Count == values.Count)
            {
                this.firstKeyDict.Remove(key1);
            }
            else
            {
                foreach (var value in values)
                {
                    this.firstKeyDict[key1].Remove(value);
                }
            }

            if (this.secondKeyDict[key2].Count == values.Count)
            {
                this.secondKeyDict.Remove(key2);
            }
            else
            {
                foreach (var value in values)
                {
                    this.secondKeyDict[key2].Remove(value);
                }
            }

            return this.doubleKeyDict.Remove(tuple);
        }
        
        public IEnumerator GetEnumerator()
        {
            foreach (var pair in this.doubleKeyDict)
            {
                yield return pair;
            }
        }
    }
}