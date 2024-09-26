using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconGame2024Q3.Entities
{
    internal class Goblin : Creature
    {
        public Goblin(Cell cell) : base(cell, "G ", 50)
        {
            Damage = 15;
            Color = ConsoleColor.DarkBlue;
        }
    } 
    internal class Orc : Creature
    {
        public Orc(Cell cell) : base(cell, "O ", 80)
        {
            Damage = 40;
            Color = ConsoleColor.DarkGreen;
        }
    } internal class Troll : Creature
    {
        public Troll(Cell cell) : base(cell, "T ", 120)
        {
            Damage = 30;
            Color = ConsoleColor.DarkYellow;
        }
    }
}
