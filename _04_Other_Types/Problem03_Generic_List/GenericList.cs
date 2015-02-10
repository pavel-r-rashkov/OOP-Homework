using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem04_Generic_List_Version;

namespace Problem03_Generic_List
{
    [Version(3.09)]  
    class GenericList<T> where T : IComparable
    {
        private T[] arr;
        private const int DEFAULT_CAPACITY = 16;
        private int count = 0;

        public GenericList(int capacity = DEFAULT_CAPACITY)
        {
            if(capacity < 1)
            {
                throw new ArgumentException("initial capacity must be bigger or equal to 1");
            }
            this.arr = new T[capacity];
            this.count = 0;
        }

        public T this[int index]
        {
            get
            {
                if(index < 0 || index >= this.count)
                {
                    throw new IndexOutOfRangeException("index out of range");
                }
                else
                {
                    return this.arr[index];
                }
            }
            set
            {
                if (index < 0 || index >= this.count)
                {
                    throw new IndexOutOfRangeException("index out of range");
                }
                else
                {
                    this.arr[index] = value;
                }
            }
        }

        public void Add(T item)
        {
            if(this.count == this.arr.Count())
            {
                T[] copy = new T[this.arr.Count() * 2];
                Array.Copy(this.arr, copy, this.count);
                this.arr = copy;
            }
            this.arr[this.count] = item;
            this.count++;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= this.count)
            {
                throw new IndexOutOfRangeException("index out of range");
            }
            else
            {
                T[] result = new T[this.arr.Count()];
                Array.Copy(this.arr, 0, result, 0, index);
                Array.Copy(this.arr, index + 1, result, index, this.arr.Count() - index - 1);
                this.arr = result;
                this.count--;
            }
        }

        public void InsertAt(T element, int index)
        {
            if (index < 0 || index >= this.count)
            {
                throw new IndexOutOfRangeException("index out of range");
            }
            else
            {
                if (this.count == this.arr.Count())
                {
                    T[] copy = new T[this.arr.Count() * 2];
                    Array.Copy(this.arr, copy, this.count);
                    this.arr = copy;
                }
                T[] result = new T[this.arr.Count()];
                Array.Copy(this.arr, 0, result, 0, index);
                result[index] = element;
                Array.Copy(this.arr, index, result, index + 1, this.arr.Count() - index - 1);
                this.arr = result;
                this.count++;
            }
        }

        public void Clear()
        {
            this.arr = new T[this.arr.Count()];
            this.count = 0;
        }

        public int Find(T element)
        {
            for (int i = 0; i < this.count; i++)
            {
                if(this.arr[i].CompareTo(element) == 0)
                {
                    return i;
                }
            }
            return -1;
        }

        public bool Contains(T element)
        {
            for (int i = 0; i < this.count; i++)
            {
                if(this.arr[i].CompareTo(element) == 0)
                {
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder("");
            for (int i = 0; i < this.count; i++)
            {
                result.Append(this.arr[i] + " ");
            }
            return result.ToString();
        }

        public T Min()
        {
            if(this.count == 0)
            {
                throw new Exception("the list must contain at least 1 element");
            }
            T result = this.arr[0];

            for(int i = 0; i < this.count; i++)
            {
                if(result.CompareTo(this.arr[i]) > 0)
                {
                    result = this.arr[i];
                }
            }
            return result;
        }

        public T Max()
        {
            if (this.count == 0)
            {
                throw new Exception("the list must contain at least 1 element");
            }
            T result = this.arr[0];

            for (int i = 0; i < this.count; i++)
            {
                if (result.CompareTo(this.arr[i]) < 0)
                {
                    result = this.arr[i];
                }
            }
            return result;
        }
    }
}
