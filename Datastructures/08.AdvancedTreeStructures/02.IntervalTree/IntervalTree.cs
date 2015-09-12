namespace _02.IntervalTree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class IntervalTree<T> where T : IComparable<T>
    {
        private SortedDictionary<T, Interval<T>> values;

        public IntervalTree()
        {
            this.values = new SortedDictionary<T, Interval<T>>();
        }

        public void Add(T min, T max)
        {
            this.values.Add(min,new Interval<T>(min,max));
        }

        public bool Remove(T min, T max)
        {
            if (values.ContainsKey(min))
            {
                return this.values.Remove(min);
            }
            return false;
        }

        public IEnumerable<Interval<T>> GetAllIntersecting(T min, T max)
        {
            return this.GetAllIntersecting(new Interval<T>(min,max));
        }

        public IEnumerable<Interval<T>> GetAllIntersecting(Interval<T> interval)
        {
            return this.values.Values.Where(s => s.Intersects(interval));
        }

        public IEnumerable<Interval<T>> GetAllContaining(T min, T max)
        {
            return this.GetAllContaining(new Interval<T>(min, max));
        }

        public IEnumerable<Interval<T>> GetAllContaining(Interval<T> interval)
        {
            return this.values.Values.Where(s => s.Contains(interval));
        }

        public Interval<T> GetFirstIntersecting(T min, T max)
        {
            return this.GetFirstIntersecting(new Interval<T>(min, max));
        }

        public Interval<T> GetFirstIntersecting(Interval<T> interval)
        {
            return this.values.Values.FirstOrDefault(s => s.Intersects(interval));
        }

        public Interval<T> GetFirstContainging(T min, T max)
        {
            return this.GetFirstIntersecting(new Interval<T>(min, max));
        }

        public Interval<T> GetFirstContainging(Interval<T> interval)
        {
            return this.values.Values.FirstOrDefault(s => s.Contains(interval));
        }
    }
}