using System;
using System.Collections;
namespace MyGeneric
{
    class MyList<T> : IEnumerable // where T: class
    {
        public int Count => data.Length;
        public int Capacity => CalculatorCapcity();
        private T[] data; //int[] Student[]
        public MyList()
        {
            data = new T[0];
        }

        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < Count)
                    return data[index];
                throw new IndexOutOfRangeException();
            }
            set
            {
                data[index] = value;
            }
        }
        public void Add(T item)
        {
            Array.Resize(ref data, data.Length + 1);
            data[data.Length - 1] = item;
        }

        public void AddRange(T[] items)
        {
            foreach (T item in items)
            {
                Add(item);
            }
        }

        public bool Remove(T item)
        {
            try
            {
                int pos = FindIndex(item);

                if (pos != 1)
                {
                    for (int i = pos; i < Count - 1; i++)
                    {
                        data[i] = data[i + 1];
                    }
                    Array.Resize(ref data, data.Length - 1);
                }
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        public bool RemoveAt(int index)
        {
            try
            {
                if (index >=0 && index < Count)
                {
                    for (int i = index; i < Count - 1; i++)
                    {
                        data[i] = data[i + 1];
                    }
                    Array.Resize(ref data, data.Length - 1);
                    return true;
                }
                throw new IndexOutOfRangeException();
                
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        public int FindIndex(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (data[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }

        public IEnumerator GetEnumerator()
        {
            foreach (T item in data)
            {
                yield return item;
            }
        }

        private int CalculatorCapcity(){
            if(Count == 0 )
                return 0;
            int capcity = 0;
            int power = 1;
            do{
                capcity = (int)Math.Pow((double)2, (double)power);
                power ++;
            }
            while(capcity < Count);

            return capcity;
        }
    }
}