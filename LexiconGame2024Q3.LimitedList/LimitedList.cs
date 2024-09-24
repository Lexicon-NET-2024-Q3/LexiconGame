using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconGame2024Q3.LimitedList
{
    public class LimitedList<T> /*where T : Creature*/
    {
        private readonly int capacity;
        private List<T> list;

        public LimitedList(int capacity)
        {
            this.capacity = capacity;
            list = new List<T>(this.capacity); 
        }

    }
}
