using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Dictionary
{
    public class KeyValue<TKey,TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }

        public KeyValue(TKey key, TValue value)
        {
            this.Key = key;
            this.Value = value;
        }

        public override bool Equals(object obj)
        {
            var other = obj as KeyValue<TKey,TValue>;

            if (obj == null)
            {
                return false;
            }
            return this.Key.Equals(other.Key) && this.Value.Equals(other.Value);
        }

        public override int GetHashCode()
        {
            return CombinedHashCode(Key.GetHashCode(), Value.GetHashCode());
        }

        public override string ToString()
        {
            return string.Format("{0} --> {1}", Key.ToString(), Value.ToString());
        }

        private int CombinedHashCode(int h1, int h2)
        {
            return h1 ^ h2;
        }

    }
}
