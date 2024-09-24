using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconGame2024Q3.Extensions
{
    internal static class MapExtensions
    {
        public static IDrawable CreatureAtExtension(this List<Creature> creatures, IDrawable drawable)
        {
            IDrawable result = drawable;

            foreach (var creature in creatures)
            {
                if (creature.Cell == drawable)
                {
                    result = creature;
                    break;
                }
            }

            return result; 
        }
        public static IDrawable CreatureAtExtension2(this List<Creature> creatures, Cell drawable)
        {
            IDrawable result = null;

            foreach (var creature in creatures)
            {
                if (creature.Cell == drawable)
                {
                    result = creature;
                    break;
                }
            }

            return result; 
        }
    }
}
