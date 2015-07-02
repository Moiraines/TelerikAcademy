using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class GenericList<T> where T : IComparable, new()  //Task 5
    {
        const int defaultCapacity = 4;

        private T[] elements;
        private int count = 0;
        private int capacity;

        public int Capacity
        {
            get { return this.capacity; }
            private set { this.capacity = value; }
        }

        public GenericList(int capacity)
        {
            this.elements = new T[capacity];
            this.capacity = capacity;
        }

        public GenericList()
            : this(defaultCapacity)
        {

        }

        public int Count
        {
            get { return this.count; }
        }

        public void Add(T element)
        {
            if (count >= elements.Length)
            {
                this.DoubleSize();
            }
            this.elements[count] = element;
            count++;
        }

        public T RemoveAt(int index)
        {
            if (index >= count || index < 0)
            {
                throw new IndexOutOfRangeException(String.Format(
                    "Invalid index: {0}.", index));
            }
            T result = elements[index];

            for (int i = index; i < count - 1; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }

            this.elements[count - 1] = new T();
            count--;
            return result;
        }

        public void InsertAt(int index, T element)
        {
            if (index > count || index < 0)
            {
                throw new IndexOutOfRangeException(String.Format(
                    "Invalid index: {0}.", index));
            }

            if (index == count)
            {
                this.Add(element);
                return;
            }

            if (count >= this.elements.Length - 1)
            {
                this.DoubleSize();
            }

            count++;

            for (int i = count; i > index; i--)
            {
                this.elements[i] = this.elements[i - 1];
            }

            this.elements[index] = element;
        }

        public T this[int index]
        {
            get
            {
                if (index >= count || index < 0)
                {
                    throw new IndexOutOfRangeException(String.Format(
                        "Invalid index: {0}.", index));
                }
                T result = elements[index];
                return result;
            }
        }

        public int IndexOf(T element)
        {
            for (int i = 0; i < count; i++)
            {
                if (this.elements[i].Equals(element))
                {
                    return i;
                }
            }

            return -1;
        }

        public void Clear()
        {
            this.elements = new T[defaultCapacity];
            this.count = 0;
            this.Capacity = defaultCapacity;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                result.Append(elements[i]);
                if (i < count - 1)
                {
                    result.Append(", ");
                }
            }

            return result.ToString();
        }

        private void DoubleSize() //Task 6
        {
            int newSize = this.elements.Length * 2;
            T[] newData = new T[newSize];

            for (int i = 0; i < count; i++)
            {
                newData[i] = this.elements[i];
            }

            this.elements = newData;
            this.Capacity *= 2;
        }

        public T Min() //Task 7
        {
            T min = this.elements[0];

            for (int i = 0; i < count; i++)
            {
                if (this.elements[i].CompareTo(min) < 0)
                {
                    min = this.elements[i];
                }
            }
            return min;
        }

        public T Max() //Task 7
        {
            T max = this.elements[0];

            for (int i = 0; i < count; i++)
            {
                if (this.elements[i].CompareTo(max) > 0)
                {
                    max = this.elements[i];
                }
            }
            return max;
        }
    }
}
