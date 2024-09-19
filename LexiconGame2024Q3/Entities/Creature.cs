using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconGame2024Q3.Entities
{
    internal class Creature : IDrawable
    {

        //public Cell Cell { get; }
        private Cell cell;
        public Cell Cell
        {
            get => cell;
            set
            {
                ArgumentNullException.ThrowIfNull(value, nameof(cell));
                cell = value; 
            }
        }
        public string Symbol { get; }

        //public string Symbol { get; }

        public ConsoleColor Color { get; protected set; } = ConsoleColor.Green;

        public Creature(Cell cell, string symbol)
        {
            Cell = cell;
            Symbol = symbol;
        }
    }
}
