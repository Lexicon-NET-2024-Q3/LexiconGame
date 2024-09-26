
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

internal class Map
{
    private Cell[,] cells; 
    public int Width { get; }
    public int Height { get; }

    public List<Creature> Creatures { get; } = new List<Creature>(); 

    public Map(int width, int height)
    {
       Width = width;
       Height = height;

        cells = new Cell[width, height];

        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                cells[y, x] = new Cell(new Position(y,x)); 
            }
        }
    }

    //ToDo: Do better
    //[return: MaybeNull]
    internal Cell? GetCell(int y, int x)
    {
        return (x < 0 || x >= Width || y < 0 || y >= Height) ? null : cells[y, x]; 
    }
    [return:MaybeNull]
    internal Cell GetCell(Position newPostion)
    {
        return GetCell(newPostion.Y, newPostion.X); 
    }

    internal void Place(Creature creature)
    {
        if (Creatures.FirstOrDefault(c => c.Cell == creature.Cell) == null)
            Creatures.Add(creature); 
    }
}