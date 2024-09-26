using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconGame2024Q3.Items
{
    internal class Potion : Item
    {
        public Potion(string symbol, ConsoleColor color, string name) : base(symbol, color, name){}

        public void Use(Creature creature) => creature.Health += 25;

        public static Potion HealthPotion() => new Potion("p ", ConsoleColor.Magenta, "Potion"); 

    }
}
