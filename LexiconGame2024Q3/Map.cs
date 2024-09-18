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
    }
}