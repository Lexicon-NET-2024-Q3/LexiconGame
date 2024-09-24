using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconGame2024Q3.UI
{
    internal class ConsoleUI
    {
        internal static ConsoleKey GetKey() => Console.ReadKey(intercept: true).Key; 

        internal static void Clear()
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(0, 0); 
        }
        internal static void Draw(Map map)
        {
            for (int y = 0; y < map.Height; y++)
            {
                for (int x = 0; x < map.Width; x++)
                {
                    Cell? cell = map.GetCell(y, x);
                    IDrawable? drawable = cell; 
                    ArgumentNullException.ThrowIfNull(drawable, nameof(drawable));

                    //drawable = map.Creatures.CreatureAtExtension(drawable);
                    drawable = map.Creatures.CreatureAtExtension2(cell)
                        ?? cell.Items.FirstOrDefault() as IDrawable ?? cell;

                    Console.ForegroundColor = drawable.Color;
                    Console.Write(drawable.Symbol);
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
