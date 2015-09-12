namespace _02.IntervalTree
{
    using System;

    public class Interval<T> : IEquatable<Interval<T>>
        where T : IComparable<T>
    {
        public T Min { get; set; }

        public T Max { get; set; }

        public Interval(T min, T max)
        {
            this.Min = min;
            this.Max = max;
        }

        public bool Contains(Interval<T> other)
        {
            if (this.Min.CompareTo(other.Min) >= 0 && this.Max.CompareTo(other.Max) <= 0)
            {
                return true;
            }
            return false;
        }

        public bool Intersects(Interval<T> other)
        {
            if (this.Min.CompareTo(other.Min) <= 0 && (this.Max.CompareTo(other.Max) <= 0 || this.Max.CompareTo(other.Max) >= 0))
            {
                return true;
            }
            return false;
        }
        
        public int CompareTo(Interval<T> other)
        {
            int min = this.Min.CompareTo(other.Min);
            int max = this.Max.CompareTo(other.Max);

            if (min == 0 && max == 0)
            {
                return 0;
            }

            if (min < 0 && max < 0)
            {
                return -1;
            }

            if (min > 0 && max > 0)
            {
                return 1;
            }

            if (min < 0 && max >= 0)
            {
                return -1;
            }

            return 1;

        }

        public bool Equals(Interval<T> other)
        {
            return this.Min.CompareTo(other.Min) == 0 && this.Max.CompareTo(other.Max) == 0;
        }
    }
}
