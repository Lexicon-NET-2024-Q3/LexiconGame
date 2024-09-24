using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconGame2024Q3.Items
{
    internal class Item : IDrawable
    {
        private readonly string name;

        public ConsoleColor Color { get; }

        public string Symbol { get; }

        public Item(string symbol, ConsoleColor color, string name)
        {
            Symbol = symbol;
            Color = color;
            this.name = name;
        }

        public override string ToString() => name; 
    }
}
