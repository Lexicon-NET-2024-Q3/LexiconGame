using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconGame2024Q3.LimitedList
{
    public class MessageLog<T> : LimitedList<T>
    {
        private static MessageLog<string> messageLog = new(6); 
        public MessageLog(int capacity) : base(capacity) { }


        public override bool Add(T item)
        {
            ArgumentNullException.ThrowIfNull(item, nameof(item));
            if (IsFull) list.RemoveAt(0);
            return base.Add(item); 
        }

    }
}
