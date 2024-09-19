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
    }
}
