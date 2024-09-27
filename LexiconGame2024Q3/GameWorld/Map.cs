
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

public class Map : IMap
{
    private Cell[,] cells;
    public int Width { get; }
    public int Height { get; }

    public List<Creature> Creatures { get; } = new List<Creature>();

    public Map(IConfiguration config, IMapSettings mapSettings, IOptions<MapSettings> options)
    {
        //var width = config.GetMapSizeFor("x");
        //var height = config.GetMapSizeFor("y");

        //var width = mapSettings.X;
        //var height = mapSettings.Y;

        var width = options.Value.X; 
        var height = options.Value.Y;

        this.Width = width;
        this.Height = height;

        cells = new Cell[Height, Width];

        for (int y = 0; y < Height; y++)
        {
            for (int x = 0; x < Width; x++)
            {
                cells[y, x] = new Cell(new Position(y, x));
            }
        }
    }




    //[return: MaybeNull]
    public Cell? GetCell(int y, int x)
    {
        return (x < 0 || x >= Width || y < 0 || y >= Height) ? null : cells[y, x];
    }
    [return: MaybeNull]
    public Cell GetCell(Position newPostion)
    {
        return GetCell(newPostion.Y, newPostion.X);
    }

    public void Place(Creature creature)
    {
        if (Creatures.FirstOrDefault(c => c.Cell == creature.Cell) == null)
            Creatures.Add(creature);
    }

    public Creature? CreatureAt(Cell cell)
    {
        return Creatures.FirstOrDefault(c => c.Cell == cell);
    }
}