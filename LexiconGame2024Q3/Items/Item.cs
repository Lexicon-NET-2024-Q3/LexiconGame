using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconGame2024Q3.Items
{
    public class Item : IDrawable
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

        public static Item Coin() => new Item("c ", ConsoleColor.Yellow, "coin");
        public static Item Stone() => new Item("s ", ConsoleColor.Gray, "stone");
    }
}
