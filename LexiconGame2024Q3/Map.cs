internal class Map
{
    private Cell[,] cells; 
    private int width;
    private int height;

    public Map(int width, int height)
    {
        this.width = width;
        this.height = height;

        cells = new Cell[width, height];

        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                cells[y, x] = new Cell(); 
            }
        }
    }
}