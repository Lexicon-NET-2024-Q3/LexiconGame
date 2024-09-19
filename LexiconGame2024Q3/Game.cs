

using LexiconGame2024Q3.Entities;

internal class Game
{
    private Map map = null!;
    private Hero hero = null!;

    internal void Run()
    {
        Initialize();
        Play();
    }

    private void Play()
    {
        bool gameInProgress = true;

        do
        {
        //DrawMap
        DrawMap();

            //GetCommand

            //Act

            //DrawMap

            //EnemyAction

            //DrawMap
            Console.ReadKey();

        } while (gameInProgress);
    }

    private void DrawMap()
    {
        Console.Clear();
        for (int y = 0; y < map.Height; y++)
        {
            for (int x = 0; x < map.Width; x++)
            {
                //Cell? cell = map.GetCell(y, x);
                ////ToDo: Handle null
                //Console.ForegroundColor = cell.Color;
                //Console.Write(cell.Symbol);

                IDrawable? drawable = map.GetCell(y, x);
                ArgumentNullException.ThrowIfNull(drawable, nameof(drawable));

                foreach (var creature in map.Creatures)
                {
                    if(creature.Cell == drawable)
                    {
                        drawable = creature;
                        break; 
                    }
                }
                Console.ForegroundColor = drawable.Color;
                Console.Write(drawable.Symbol); 
            }
            Console.WriteLine(); 
        }
        Console.ForegroundColor = ConsoleColor.Gray;  
    }

    private void Initialize()
    {
        //ToDo: Read from config maybe
        map = new Map(width: 10, height: 10);
        Cell heroCell = map.GetCell(0,0); 
        hero = new Hero(heroCell);
        map.Creatures.Add(hero); 
        
    }
}