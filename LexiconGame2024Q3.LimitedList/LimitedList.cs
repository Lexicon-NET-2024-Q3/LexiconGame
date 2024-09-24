using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconGame2024Q3.LimitedList
{
    public class LimitedList<T> : IEnumerable<T>
    {
        private readonly int capacity;
        private List<T> list;

        public int Count => list.Count;

        public bool IsFull => capacity <= Count;

        public LimitedList(int capacity)
        {
            this.capacity = Math.Max(capacity, 2);
            list = new List<T>(this.capacity); 
        }

        public bool Add(T item)
        {
            ArgumentNullException.ThrowIfNull(item, nameof(item));
            if (IsFull) return false;
            list.Add(item); return true; 
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in list)
            {
                //Do something if needed

                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator(); 
    }
}
