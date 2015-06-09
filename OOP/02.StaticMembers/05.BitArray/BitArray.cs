using System;
using System.Numerics;


namespace _05.BitArray
{
    class BitArray
    {
        private bool[] array;

        public BitArray(int size)
        {
            if (size > 100000)
            {
                throw new ArgumentException("the size of the BitArray can't be bigger than 100000");
            }
            this.array = new bool[size];
        }

        public int this[int i]
        {
            get { return this.array[i] ? 1 : 0; }
            set
            {
                if (value == 1 || value == 0)
                {
                    this.array[i] = value == 1;
                }
                else
                {
                    throw new ArgumentException("the index should be set to 1 or 0 only");
                }
            }
        }

        public override string ToString()
        {
            return this.ConvertToDecimal().ToString();
        }

        public BigInteger ConvertToDecimal()
        {
            BigInteger sum = 0;
            for (int i = 0; i < this.array.Length; i++)
            {
                if (array[i])
                {
                    sum += BigInteger.Pow(2,i);
                }
            }
            return sum;
        }
    }
}
