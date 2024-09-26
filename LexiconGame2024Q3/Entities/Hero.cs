
internal class Hero : Creature
{
    public LimitedList<Item> BackPack { get;  }
    public Hero(Cell cell) : base(cell, "H ", 100)
    {
        Color = ConsoleColor.White;
        
        //ToDo read from config
        BackPack = new LimitedList<Item>(3);
    }
}