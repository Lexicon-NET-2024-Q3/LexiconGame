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
        private int health;
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
        public int Health
        {
            get => health;
            set => health = value >= MaxHealth ? MaxHealth : value;
        }
        public int MaxHealth { get; }

        public bool IsDead => health <= 0; 

        public int Damage { get; protected set; } = 50; 

        public ConsoleColor Color { get; protected set; } = ConsoleColor.Green;

        public Creature(Cell cell, string symbol, int maxHealth)
        {
            Cell = cell;
            Symbol = symbol;
            MaxHealth = maxHealth;
            Health = maxHealth; 
        }
    }
}
