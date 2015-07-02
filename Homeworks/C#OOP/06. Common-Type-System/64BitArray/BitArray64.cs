namespace _64BitArray
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;
    public class BitArray64 : IEnumerable<int>
    {
        private ulong number;

        public BitArray64(ulong number)
        {
            this.Number = number;
        }

        public ulong Number 
        {
            get { return this.number; }
            set { this.number = value; } 
        }


        public override bool Equals(object param)
        {
            return this.Number.Equals((param as BitArray64).Number);
        }

        public int this[int pos]
        {
            get
            {
                if (pos < 0 || pos >= 64)
                {
                    throw new IndexOutOfRangeException("Invalid position.");
                }

                return ((int)(this.Number >> pos) & 1);
            }
            set
            {
                if (pos < 0 || pos >= 64)
                {
                    throw new IndexOutOfRangeException("Invalid position.");
                }

                if (value < 0 || value > 1)
                {
                    throw new ArgumentException("Invalid bit value.");
                }

                if (((int)(this.Number >> pos) & 1) != value)
                {
                    this.Number ^= (1ul << pos);
                }
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int pos = 0; pos < 64; pos++)
            {
                result.Insert(0, ((this.Number >> pos) & 1));
            }

            return result.ToString();
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int pos = 0; pos < 64; pos++)
            {
                yield return this[pos];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override int GetHashCode()
        {
            return this.number.GetHashCode();
        }

        public static bool operator ==(BitArray64 firstEl, BitArray64 secondEl)
        {
            return BitArray64.Equals(firstEl, secondEl);
        }

        public static bool operator !=(BitArray64 firstEl, BitArray64 secondEl)
        {
            return !(BitArray64.Equals(firstEl, secondEl));
        }
    }
}
